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
                if (cls.login(txt_usuario.Text,txt_pass.Text) == "t")
                {
                    GestionarHuella gHuella = new GestionarHuella(false, 0);
                    gHuella.Show();
                    this.Hide();
                
                }
                else if (cls.login(txt_usuario.Text, txt_pass.Text) == "f")
                    MessageBox.Show("Credenciales incorrectas", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("La base de datos está desconectada", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}
