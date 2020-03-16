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
        public Relojes()
        {
            InitializeComponent();
        }

        ZKSoftware dispositivo = new ZKSoftware(Modelo.X628C);

        private void Relojes_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            clsData clsData = new clsData();
            DataTable table = new DataTable();
            table.Columns.Add("IP", typeof(string));
            table.Columns.Add("LUGAR", typeof(string));
            relojes = clsData.getRelojes();
            int i = 0;
            while (relojes[i, 0] != null)
            {
                table.Rows.Add(relojes[i, 0], relojes[i, 1]);
                i++;
            }
            grid_relojes.DataSource = table;
            grid_relojes.Refresh();
            this.Cursor = Cursors.Default;
        }

        private void btn_sincronizar_Click(object sender, EventArgs e)
        {
            string[] allHuellas = new string[10];
            Dictionary<int, string> huellas = new Dictionary<int, string>();
            clsData data = new clsData();
            List<UserInfo> userInfos = new List<UserInfo>();
            List<UsuarioInformacion> users = new List<UsuarioInformacion>();
            int j = 0;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                while (relojes[j, 0] != null)
                {
                    if (!dispositivo.DispositivoConectar(relojes[j, 0], 1, false))
                        MessageBox.Show("Error al conectarse al reloj", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        users = data.getUsers();
                        if (dispositivo.UsuarioBuscarTodos(false))
                        {
                            BorrarUsuariosSinNombreReloj(); //ya no hay usuarios sin nombre en el reloj
                            lstUser = dispositivo.ListaUsuarios;
                        }
                        else
                        {
                            MessageBox.Show(dispositivo.ERROR);
                        }

                        foreach (var item in users)
                        {

                            allHuellas = data.getHuellas(item.NumeroCredencial.ToString());
                            huellas = data.huellasSinEspacio(allHuellas);

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
                                foreach (var h in huellas)
                                {
                                    dispositivo.UsuarioAgregar(Int16.Parse(item.NumeroCredencial.ToString()), item.Nombre, item.Permiso, h.Key, h.Value);
                                }
                            }
                        }
                    }
                    this.Cursor = Cursors.Default;
                    j++;
                    dispositivo.DispositivoDesconectar();
                    MessageBox.Show("OK");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private UsuarioInformacion buscarUsuarioReloj(int idPersona)
        {
            UsuarioInformacion u = null;
            foreach (var item in lstUser)
            {
                if (item.NumeroCredencial == idPersona)
                {
                    u = item;
                }
            }
            return u;
        }


        private void grid_relojes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BorrarUsuariosSinNombreReloj()
        {
            List<UsuarioInformacion> Users = dispositivo.ListaUsuarios;
            foreach (var item in Users)
            {
                if (item.Nombre == "" && item.Permiso == Permiso.UsuarioNormal)
                {
                    dispositivo.UsuarioBuscar(item.NumeroCredencial);
                }

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
