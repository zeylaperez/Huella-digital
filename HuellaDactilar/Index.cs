using HuellaDactilar.Controller;
using System;
using System.Windows.Forms;

namespace HuellaDactilar
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text != "" && txt_pass.Text != "")
            {
                clsConn cls = new clsConn();
                if (cls.login(txt_usuario.Text, txt_pass.Text) == "t")
                {
                   /* if (!cls.checkPermiso(txt_usuario.Text))
                    {
                        MessageBox.Show("El usuario " + txt_usuario.Text + " no tiene permisos para acceder al sistema.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clean();
                    }*/
                    GestionarHuella gHuella = new GestionarHuella(false, 0);
                    gHuella.Show();
                    this.Hide();
                }
                else if (cls.login(txt_usuario.Text, txt_pass.Text) == "f")
                {
                    MessageBox.Show("Credenciales incorrectas.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clean();
                }
                else
                {
                    MessageBox.Show("La base de datos está desconectada.", "Alerta",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clean();
                }
            }
        }


        public void clean()
        {
            txt_usuario.Text = "";
            txt_pass.Text = "";
        }

        private void grp_auth_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_acceder_Click(sender, e);
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_acceder_Click(sender, e);
            }
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void Txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            ConfigurarBD configurarBD = new ConfigurarBD();
            configurarBD.Show();
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
