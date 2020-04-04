using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Windows.Forms;
using Npgsql;
using System.Net.NetworkInformation;

namespace HuellaDactilar.Controller
{
    class clsConn
    {
        //Conexion a traves de app.config
        string sql = ConfigurationManager.ConnectionStrings["HuellaDactilar.Properties.Settings.asistenciaConnectionString"].ConnectionString;
        string dominio = "eti.biocubafarma.cu";
        string path = "LDAP://eti.biocubafarma.cu";

        public string login(string user, string psw)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(sql);
                conn.Open();
                //Define a query
                string cred = "SELECT us.username FROM auth.users us WHERE us.username = @user " +
                         " LIMIT 1";
                NpgsqlCommand cmd = new NpgsqlCommand(cred, conn);
                cmd.Parameters.AddWithValue("@user", user);
                // Execute a query
                NpgsqlDataReader rCred = cmd.ExecuteReader();
                if (rCred.Read())
                {
                    DirectoryEntry entry = new DirectoryEntry(path, user + "@" + dominio, psw);
                    try
                    {
                        DirectorySearcher search = new DirectorySearcher(entry);
                        SearchResult result = search.FindOne();
                        if (result == null)
                        {
                            return "t";
                        }
                        else
                        {
                            conn.Close();
                            return "t";
                        }
                    }
                    catch
                    {
                        return "f";
                    }
                }
                else { conn.Close(); return "f"; }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return "f";
            }
        }

        public string[,] getRelojes()
        {
            string[,] relojes;
            try
            {
                NpgsqlConnection myconn = new NpgsqlConnection(sql);
                myconn.Open();
                string data = "SELECT r.ip, r.lugar FROM reloj.relojes r WHERE r.active = @activo";
                NpgsqlCommand command = new NpgsqlCommand(data, myconn);
                command.Parameters.AddWithValue("@activo", true);
                NpgsqlDataReader reader = command.ExecuteReader();
                int rows = 0;
                relojes = new string[byte.MaxValue, 2];
                while (reader.Read())
                {
                    relojes[rows, 0] = reader.GetValue(0).ToString();
                    relojes[rows, 1] = reader.GetValue(1).ToString();
                    rows++;
                }
                return relojes;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        public bool checkPermiso(string user)
        {
            try
            {
                NpgsqlConnection myconn = new NpgsqlConnection(sql);
                myconn.Open();
                string data = "select u.name, u.iduser from auth.users u, auth.users_roles ur" +
                    " where u.username=@user and u.iduser=ur.iduser and ur.idrole=33";
                NpgsqlCommand command = new NpgsqlCommand(data, myconn);
                command.Parameters.AddWithValue("@user", user);
                NpgsqlDataReader reader = command.ExecuteReader();
                myconn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
    }
}
