using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuellaDactilar.Controller;
using System.Configuration;

namespace HuellaDactilar
{
    public partial class ConfigurarBD : Form
    {
        private ConnectionStringsManager connection = new ConnectionStringsManager();

        public ConfigurarBD()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nameAsistencia = "HuellaDactilar.Properties.Settings.asistenciaConnectionString";
            string connectionStringAsistencia = "Host=" + textBox_serv_asis.Text + ";Database=" + textBox4_bd_asis.Text + ";Username=" + textBox1_user_asis.Text + ";Password=" + textBox2_pass_asis.Text + ";Persist Security Info=True";
            connection.SaveConnectionString(nameAsistencia, connectionStringAsistencia);
           string a= connection.GetConnectionString(nameAsistencia);

            string nameGrehu = "HuellaDactilar.Properties.Settings.grehu_etiConnectionString";
            string connectionStringGrehu = "Host=" + textBox6_serv_grehu.Text + ";Database=" + textBox5_bd_grehu.Text + ";Username=" + textBox8_user_grehu.Text + ";Password=" + textBox7_pass_grehu.Text + ";Persist Security Info=True";
            connection.SaveConnectionString(nameGrehu, connectionStringGrehu);
            string b=connection.GetConnectionString(nameGrehu);
            MessageBox.Show(a + "      " + b);
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarBD_Load(object sender, EventArgs e)
        {

        }
    }
}
