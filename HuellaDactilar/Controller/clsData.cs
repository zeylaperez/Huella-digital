using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZKSoftwareAPI;

namespace HuellaDactilar.Controller
{
    class clsData
    {
        //Conexion global
        // private string conn = "Server=192.168.2.13;User Id=postgres;" +
        // "Password=*cmi*;Database=grehu_eti;";
        private string conn = "Server=localhost;User Id=postgres;" +
                                   "Password=postgres;Database=grehu_eti;";
        public bool insertData(Int64 idPersona, string numTargeta, string huellas, string nombre, string apellidos, string permiso)
        {
            Int64 cantDatos = 0;
            try
            {
                NpgsqlConnection insert = new NpgsqlConnection(conn);
                NpgsqlConnection select = new NpgsqlConnection(conn);
                select.Open();
                string selectDatos = "SELECT COUNT(eth.id) FROM eti_huella eth WHERE " +
                    "eth.id_persona = @id_persona";
                NpgsqlCommand selectCommand = new NpgsqlCommand(selectDatos, select);
                selectCommand.Parameters.AddWithValue("@id_persona", idPersona);
                NpgsqlDataReader readerSelect = selectCommand.ExecuteReader();
                if (readerSelect.Read())
                    cantDatos = Convert.ToInt64(readerSelect[0].ToString());
                select.Close();
                if (cantDatos > 0)
                {
                    NpgsqlConnection update = new NpgsqlConnection(conn);
                    update.Open();
                    string upd = "UPDATE eti_huella SET huellas = @huellas, permiso = @permiso WHERE id_persona = @id_persona";
                    NpgsqlCommand updCommand = new NpgsqlCommand(upd, update);
                    updCommand.Parameters.AddWithValue("@huellas", huellas);
                    updCommand.Parameters.AddWithValue("@permiso", permiso);
                    updCommand.Parameters.AddWithValue("@id_persona", idPersona);
                    NpgsqlDataReader readerUpdate = updCommand.ExecuteReader();
                    update.Close();
                }
                else
                {
                    insert.Open();
                    string insertData = "INSERT INTO public.eti_huella (id_persona,num_tarjeta,huellas,activo,nombre,apellidos,permiso) VALUES(@id_persona, @num_tarjeta,@huellas,@activo, @nombre, @apellidos,@permiso)";

                    NpgsqlCommand command = new NpgsqlCommand(insertData, insert);
                    command.Parameters.AddWithValue("@id_persona", idPersona);
                    command.Parameters.AddWithValue("@num_tarjeta", numTargeta);
                    command.Parameters.AddWithValue("@huellas", huellas);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellidos", apellidos);
                    command.Parameters.AddWithValue("@permiso", permiso);
                    command.Parameters.AddWithValue("@activo", true);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    insert.Close();
                }
                return true;
            }

            catch (NpgsqlException)
            {
                return false;
            }
        }

        public string[] getHuellas(string num_tarjeta)
        {
            string[] marcas = new string[10];
            try
            {
                NpgsqlConnection myconn = new NpgsqlConnection(conn);
                myconn.Open();
                string data = "SELECT h.huellas FROM public.eti_huella as h where h.activo = @activo and h.huellas IS NOT NULL " +
                    "and h.num_tarjeta = @num_targ";
                NpgsqlCommand command = new NpgsqlCommand(data, myconn);
                command.Parameters.AddWithValue("@activo", true);
                command.Parameters.AddWithValue("@num_targ", num_tarjeta);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    marcas = reader[0].ToString().Split(',');
                myconn.Close();
                return marcas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool eliminarHuella(string num_tarjeta, string huellas)
        {
            //string[] huellas = getHuellas(num_tarjeta);
            //huellas[index] = string.Empty;
            try
            {
                NpgsqlConnection update = new NpgsqlConnection(conn);
                update.Open();
                string upd = "UPDATE eti_huella SET huellas = @huellas WHERE num_tarjeta = @num_targ";
                NpgsqlCommand updCommand = new NpgsqlCommand(upd, update);
                updCommand.Parameters.AddWithValue("@huellas", huellas);
                updCommand.Parameters.AddWithValue("@num_targ", num_tarjeta);
                NpgsqlDataReader reader = updCommand.ExecuteReader();
                update.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public string getPermiso(string num_tarjeta)
        {
            string permiso = null;
            try
            {
                NpgsqlConnection myconn = new NpgsqlConnection(conn);
                myconn.Open();
                string data = "SELECT h.permiso FROM public.eti_huella as h where h.activo = @activo and h.num_tarjeta = @num_targ";
                NpgsqlCommand command = new NpgsqlCommand(data, myconn);
                command.Parameters.AddWithValue("@activo", true);
                command.Parameters.AddWithValue("@num_targ", num_tarjeta);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    permiso = reader[0].ToString();
                myconn.Close();
                return permiso;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string[,] getRelojes()
        {
            string connAsistencia = "Server=localhost;User Id=postgres;" +
                                       "Password=postgres;Database=asistencia;";
            string[,] relojes;
            try
            {
                NpgsqlConnection myconn = new NpgsqlConnection(connAsistencia);
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
        public bool update(string idPersona, DateTime fecha, DateTime hora, string ipReloj)
        {
            Int64 id = 0;
            string[] ip = new string[4];
            try
            {
                NpgsqlConnection dMarcas = new NpgsqlConnection(conn);
                string instertMarcas = "INSERT INTO marca_no_identificada VALUES(@id,@idPersona,@fecha,@hora)";
                NpgsqlCommand command = new NpgsqlCommand(instertMarcas, dMarcas);
                dMarcas.Open();
                ip = ipReloj.Split('.');
                id = Int64.Parse(ip[2] + ip[3] + fecha.Year.ToString() + fecha.Month.ToString() + fecha.Day.ToString()
                + hora.Hour.ToString() + hora.Minute.ToString() + hora.Second.ToString());
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@idPersona", idPersona);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@hora", hora);
                NpgsqlDataReader reader = command.ExecuteReader();
                dMarcas.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public List<int> Eliminar()
        {
            List<int> num_tarjeta = new List<int>();
            int i = 0;
            try
            {
                NpgsqlConnection dMarcas = new NpgsqlConnection(conn);
                string instertMarcas = "SELECT p.num_tarjeta FROM personal p WHERE p.baja = @baja";
                NpgsqlCommand command = new NpgsqlCommand(instertMarcas, dMarcas);
                dMarcas.Open();
                command.Parameters.AddWithValue("@baja", true);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    num_tarjeta[i] = int.Parse(reader[0].ToString());
                    i++;
                }
                dMarcas.Close();
                return num_tarjeta;
            }
            catch
            {
                return null;
            }
        }
        public List<UsuarioInformacion> getUsers()
        {
            List<UsuarioInformacion> users = new List<UsuarioInformacion>();
            try
            {
                NpgsqlConnection user = new NpgsqlConnection(conn);
                string selectUser = "SELECT eh.num_tarjeta,eh.nombre,eh.apellidos,eh.permiso FROM eti_huella eh WHERE eh.activo = @activo";
                NpgsqlCommand command = new NpgsqlCommand(selectUser, user);
                user.Open();
                command.Parameters.AddWithValue("@activo", true);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UsuarioInformacion u = new UsuarioInformacion();
                    u.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    u.NumeroCredencial = Int32.Parse(reader[0].ToString());
                    if (reader[3].ToString() == "UsuarioNormal")
                    {
                        u.Permiso = Permiso.UsuarioNormal;
                    }
                    else
                    {
                        if (reader[3].ToString() == "UsuarioEnrolador")
                        {
                            u.Permiso = Permiso.UsuarioEnrolador;
                        }
                        else
                        {
                            u.Permiso = Permiso.UsuarioAdministrador;
                        }
                    }


                    users.Add(u);
                }
                return users;
            }
            catch
            {
                return null;
            }
        }
        public Dictionary<int, string> huellasSinEspacio(string[] huellas)
        {
            Dictionary<int, string> dicc = new Dictionary<int, string>();

            for (int i = 0; i < huellas.Length; i++)
            {
                if (huellas[i] != string.Empty)
                    dicc.Add(i, huellas[i]);
            }
            return dicc;
        }
    }
}
