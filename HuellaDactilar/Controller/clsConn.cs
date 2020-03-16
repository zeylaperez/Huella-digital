using System;
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

        public string login(string user, string psw)
        {
            //  string sql = "Server=192.168.2.13;User Id=postgres;" +
            //  "Password=*cmi*;Database=asistencia;";
            //string dominio = "eti.biocubafarma.cu";
            // string path = "LDAP://eti.biocubafarma.cu";

            string sql = "Server=localhost;User Id=postgres;" +
              "Password=postgres;Database=asistencia;";
            
            NpgsqlConnection conn = new NpgsqlConnection(sql);
            conn.Open();
            return "t";
            /* try
             {
                 NpgsqlConnection conn = new NpgsqlConnection(sql);
                 conn.Open();
                 // Define a query
                 string cred = "SELECT us.username FROM auth.users us WHERE us.username = @user " +
                     " LIMIT 1";
                 NpgsqlCommand cmd = new NpgsqlCommand(cred, conn);
                 cmd.Parameters.AddWithValue("@user",user);
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
                     catch {
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

     */
        }
    }
}
