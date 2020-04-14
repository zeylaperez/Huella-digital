using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using HuellaDactilar.Controller;
using ZKSoftwareAPI;


namespace HuellaDactilar
{
    public partial class Relojes : Form
    {
        List<MachineInfo> lstMachineInfo = new List<MachineInfo>();
        List<UsuarioInformacion> lstUser = new List<UsuarioInformacion>();
        private string[,] relojes;
        public ClearFlag clear;
        clsData data = new clsData();
        int progreso=0;
        public Relojes()
        {
            InitializeComponent();
            progressBar1.Value = 0;
        }

        ZKSoftware dispositivo = new ZKSoftware(Modelo.X628C);

        private void Relojes_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            clsConn clsConn = new clsConn();
            DataTable table = new DataTable();
            table.Columns.Add("IP", typeof(string));
            table.Columns.Add("LUGAR", typeof(string));
            relojes = clsConn.getRelojes();
            int i = 0;
            while (relojes[i, 0] != null)
            {
                table.Rows.Add(relojes[i, 0], relojes[i, 1]);
                i++;
            }
            progreso = 80/i;
            grid_relojes.DataSource = table;
            grid_relojes.Refresh();
            this.Cursor = Cursors.Default;
        }

        private void btn_sincronizar_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 20;

            string[] allHuellas = new string[10];
            Dictionary<int, string> huellas = new Dictionary<int, string>();
            List<UserInfo> userInfos = new List<UserInfo>();
            List<UsuarioInformacion> users = new List<UsuarioInformacion>();

            //Actualiza eti_huella segun el estado de los trabajadores en la tabla personal
            data.UpdateEstadoPersonal();
            //Obtener los usuarios en eti_huella
            users = data.getUsers();
            int j = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                while (relojes[j, 0] != null)
                {
                    if (!dispositivo.DispositivoConectar(relojes[j, 0], 1, false))
                        MessageBox.Show("Error al conectarse al reloj " + relojes[j, 0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        //Buscar todos los usuarios del dispositivo
                        if (dispositivo.UsuarioBuscarTodos(false))
                        {
                            lstUser = dispositivo.ListaUsuarios;
                        }

                        //eliminar los churres del reloj
                        EliminarUsuariosReloj(lstUser);

                        foreach (var item in users) //recorrer lista de usuarios en BD
                        {
                            allHuellas = data.getHuellas(item.NumeroCredencial.ToString());
                            huellas = data.huellasSinEspacio(allHuellas);

                            //agregar huellas a usuarios que estan en el reloj
                            if (buscarUsuarioReloj(int.Parse(item.NumeroCredencial.ToString())) != null)
                            {
                                UsuarioInformacion usuario = buscarUsuarioReloj(int.Parse(item.NumeroCredencial.ToString()));
                                List<UsuarioHuella> huellaslist = usuario.Huellas;

                                foreach (var marcas in huellas)
                                {
                                    bool enc = false;
                                    foreach (var h in huellaslist)
                                    {
                                        if (marcas.Value == h.B64Huella)
                                        {
                                            enc = true;
                                        }
                                    }
                                    if (!enc)
                                    {
                                        UsuarioHuella uh = new UsuarioHuella();
                                        uh.B64Huella = marcas.Value;
                                        uh.IndexHuella = marcas.Key;
                                        huellaslist.Add(uh);
                                    }
                                }
                            }
                            else
                            {
                                //insertar usuarios sin huellas en el reloj
                                if (huellas.Count == 0)
                                {
                                    dispositivo.UsuarioAgregar(Int32.Parse(item.NumeroCredencial.ToString()), item.Nombre, item.Permiso, 0, "");
                                }
                                else
                                {
                                    //insertar usuarios nuevos en el reloj
                                    foreach (var h in huellas)
                                    {
                                        dispositivo.UsuarioAgregar(Int32.Parse(item.NumeroCredencial.ToString()), item.Nombre, item.Permiso, h.Key, h.Value);
                                    }
                                }
                            }
                        }
                    }
                    this.Cursor = Cursors.Default;
                    progressBar1.Value += progreso;
                    j++;
                    dispositivo.DispositivoDesconectar();
                }
                if (progressBar1.Value > 100)
                    progressBar1.Value = 100;
             //   MessageBox.Show("Proceso terminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public UsuarioInformacion buscarUsuarioReloj(int idPersona)
        {
            UsuarioInformacion u = null;
            if (lstUser != null)
            {
                foreach (var item in lstUser)
                {
                    if (item.NumeroCredencial == idPersona)
                    {
                        u = item;
                    }
                }
            }
            return u;
        }


        public void EliminarUsuariosReloj(List<UsuarioInformacion> lista)
        {
            List<UsuarioInformacion> listapersonal = data.getUsersInPersonal();
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    bool enc = false;
                    foreach (var l in listapersonal)
                    {
                        if (item.NumeroCredencial == l.NumeroCredencial)
                            enc = true;
                    }
                    if (!enc)
                        dispositivo.UsuarioBorrar(item.NumeroCredencial);
                }
            }
        }

        private void grid_relojes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 20;
            MessageBox.Show("OK"); 
            progressBar1.Value = 100;

        }
    }
}
