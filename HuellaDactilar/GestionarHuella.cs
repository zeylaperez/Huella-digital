using System;
using System.Windows.Forms;
using HuellaDactilar.Controller;
using Npgsql;

namespace HuellaDactilar
{
    public partial class GestionarHuella : Form
    {
        private string[] marcas;
        clsConn data = new clsConn();
        clsData clsConn = new clsData();
        private int dedo;
        private string huellas;
        private Int64 idPersona;
        private string numTargeta;
        private string nombre;
        private string apell;
        private bool flag = false;
        private string permiso;
        public GestionarHuella(bool Flag, Int64 ID)
        {
            InitializeComponent();
            flag = Flag;
            idPersona = ID;
        }


        private void GestionarHuella_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grehu_etiDataSet.personal' table. You can move, or remove it, as needed.
            this.personalTableAdapter.Fill(this.grehu_etiDataSet.personal);
        }

        private void asistenciaDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text != string.Empty)
                personalBindingSource.Filter = string.Format("num_tarjeta LIKE '{0}%' or nombre LIKE '{0}%'", txt_Buscar.Text);
            else
                personalBindingSource.Filter = string.Empty;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void grid_personas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtener los datos de las personas
            idPersona = Int64.Parse(grid_personas.CurrentRow.Cells[0].Value.ToString());
            numTargeta = grid_personas.CurrentRow.Cells[1].Value.ToString();
            nombre = grid_personas.CurrentRow.Cells[2].Value.ToString();
            apell = grid_personas.CurrentRow.Cells[3].Value.ToString();
            clsData cls = new clsData();

            try
            {
                cbox_D0.Checked = false;
                cbox_D1.Checked = false;
                cbox_D2.Checked = false;
                cbox_D3.Checked = false;
                cbox_D4.Checked = false;
                cbox_D5.Checked = false;
                cbox_D6.Checked = false;
                cbox_D7.Checked = false;
                cbox_D8.Checked = false;
                cbox_D9.Checked = false;
                marcas = new string[10];
                //Huellas registradas
                marcas = cls.getHuellas(grid_personas.CurrentRow.Cells[1].Value.ToString());
                for (int i = 0; i < marcas.Length; i++)
                {
                    //Seleccionar los dedos con huellas
                    if (marcas[i] != string.Empty && marcas[i] != null)
                    {
                        switch (i)
                        {
                            case 0:
                                cbox_D0.Checked = true;
                                break;
                            case 1:
                                cbox_D1.Checked = true;
                                break;
                            case 2:
                                cbox_D2.Checked = true;
                                break;
                            case 3:
                                cbox_D3.Checked = true;
                                break;
                            case 4:
                                cbox_D4.Checked = true;
                                break;
                            case 5:
                                cbox_D5.Checked = true;
                                break;
                            case 6:
                                cbox_D6.Checked = true;
                                break;
                            case 7:
                                cbox_D7.Checked = true;
                                break;
                            case 8:
                                cbox_D8.Checked = true;
                                break;
                            case 9:
                                cbox_D9.Checked = true;
                                break;
                        }
                    }
                }
                //permiso registrado
                string perm = cls.getPermiso(numTargeta);
                if (perm == "UsuarioAdministrador")
                    radioButton3.Checked = true;
                else
                {
                    if (perm == "UsuarioEnrolador")
                        radioButton2.Checked = true;
                    else
                        radioButton1.Checked = true;
                }
            }
            catch (NpgsqlException exc)
            {
                MessageBox.Show(exc.Message);
            }

            gbox_Dedos.Visible = true;
            groupBox1.Visible = true;
            img_manos.Visible = true;
            lbl_trabajador.Visible = true;
            lbl_cantDedos.Text = cantDedos(marcas).ToString();
            lbl_cantDedos.Visible = true;
            lbl_msgCantDedos.Visible = true;
            lbl_trabajador.Text = grid_personas.CurrentRow.Cells[2].Value.ToString() + " " + grid_personas.CurrentRow.Cells[3].Value.ToString();
        }

        private void cbox_D0_Click(object sender, EventArgs e)
        {
            if (cbox_D0.Checked)
            {
                dedo = 0;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    permiso = "UsuarioNormal";
                AddHuella addHuella = new AddHuella(marcas, dedo, idPersona, numTargeta, nombre, apell, permiso);
                addHuella.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este dedo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcas[0] = string.Empty;
                    if (clsConn.eliminarHuella(numTargeta, unirHuellas(marcas)))
                        cbox_D0.Checked = false;
                }
                else
                    cbox_D0.Checked = true;
            }
        }

        private void cbox_D1_Click(object sender, EventArgs e)
        {

            if (cbox_D1.Checked)
            {
                dedo = 1;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    permiso = "UsuarioNormal";
                AddHuella addHuella = new AddHuella(marcas, dedo, idPersona, numTargeta, nombre, apell, permiso);
                addHuella.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este dedo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcas[1] = string.Empty;
                    if (clsConn.eliminarHuella(numTargeta, unirHuellas(marcas)))
                        cbox_D0.Checked = false;
                }
                else
                    cbox_D1.Checked = true;
            }
        }

        private void cbox_D2_Click(object sender, EventArgs e)
        {
            if (cbox_D2.Checked)
            {
                dedo = 2;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    permiso = "UsuarioNormal";
                AddHuella addHuella = new AddHuella(marcas, dedo, idPersona, numTargeta, nombre, apell, permiso);
                addHuella.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este dedo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcas[2] = string.Empty;
                    if (clsConn.eliminarHuella(numTargeta, unirHuellas(marcas)))
                        cbox_D0.Checked = false;
                }
                else
                    cbox_D2.Checked = true;
            }
        }

        private void cbox_D3_Click(object sender, EventArgs e)
        {
            if (cbox_D3.Checked)
            {
                dedo = 3;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    permiso = "UsuarioNormal";
                AddHuella addHuella = new AddHuella(marcas, dedo, idPersona, numTargeta, nombre, apell, permiso);
                addHuella.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este dedo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcas[3] = string.Empty;
                    if (clsConn.eliminarHuella(numTargeta, unirHuellas(marcas)))
                        cbox_D0.Checked = false;
                }
                else
                    cbox_D3.Checked = true;
            }
        }

        private void cbox_D4_Click(object sender, EventArgs e)
        {
            if (cbox_D4.Checked)
            {
                dedo = 4;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    permiso = "UsuarioNormal";
                AddHuella addHuella = new AddHuella(marcas, dedo, idPersona, numTargeta, nombre, apell, permiso);
                addHuella.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este dedo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcas[4] = string.Empty;
                    if (clsConn.eliminarHuella(numTargeta, unirHuellas(marcas)))
                        cbox_D0.Checked = false;
                }
                else
                    cbox_D4.Checked = true;
            }
        }

        private void cbox_D5_Click(object sender, EventArgs e)
        {
            if (cbox_D5.Checked)
            {
                dedo = 5;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    permiso = "UsuarioNormal";
                AddHuella addHuella = new AddHuella(marcas, dedo, idPersona, numTargeta, nombre, apell, permiso);
                addHuella.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este dedo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcas[5] = string.Empty;
                    if (clsConn.eliminarHuella(numTargeta, unirHuellas(marcas)))
                        cbox_D0.Checked = false;
                }
                else
                    cbox_D5.Checked = true;
            }
        }

        private void cbox_D6_Click(object sender, EventArgs e)
        {
            if (cbox_D6.Checked)
            {
                dedo = 6;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    permiso = "UsuarioNormal";
                AddHuella addHuella = new AddHuella(marcas, dedo, idPersona, numTargeta, nombre, apell, permiso);
                addHuella.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este dedo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcas[6] = string.Empty;
                    if (clsConn.eliminarHuella(numTargeta, unirHuellas(marcas)))
                        cbox_D0.Checked = false;
                }
                else
                    cbox_D6.Checked = true;
            }
        }

        private void cbox_D7_Click(object sender, EventArgs e)
        {
            if (cbox_D7.Checked)
            {
                dedo = 7;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    permiso = "UsuarioNormal";
                AddHuella addHuella = new AddHuella(marcas, dedo, idPersona, numTargeta, nombre, apell, permiso);
                addHuella.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este dedo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcas[7] = string.Empty;
                    if (clsConn.eliminarHuella(numTargeta, unirHuellas(marcas)))
                        cbox_D0.Checked = false;
                }
                else
                    cbox_D7.Checked = true;
            }
        }

        private void cbox_D8_Click(object sender, EventArgs e)
        {
            if (cbox_D8.Checked)
            {
                dedo = 8;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    permiso = "UsuarioNormal";
                AddHuella addHuella = new AddHuella(marcas, dedo, idPersona, numTargeta, nombre, apell, permiso);
                addHuella.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este dedo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcas[8] = string.Empty;
                    if (clsConn.eliminarHuella(numTargeta, unirHuellas(marcas)))
                        cbox_D0.Checked = false;
                }
                else
                    cbox_D8.Checked = true;
            }
        }

        private void cbox_D9_Click(object sender, EventArgs e)
        {
            if (cbox_D9.Checked)
            {
                dedo = 9;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    permiso = "UsuarioNormal";
                AddHuella addHuella = new AddHuella(marcas, dedo, idPersona, numTargeta, nombre, apell, permiso);
                addHuella.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este dedo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcas[9] = string.Empty;
                    if (clsConn.eliminarHuella(numTargeta, unirHuellas(marcas)))
                        cbox_D0.Checked = false;
                }
                else
                    cbox_D9.Checked = true;
            }
        }

        private void menuRelojes_Click(object sender, EventArgs e)
        {
            Relojes clsRelojes = new Relojes();
            clsRelojes.Show();
        }

        private void GestionarHuella_FormClosing(object sender, FormClosingEventArgs e)
        {
            Index index = new Index();
            index.Show();
        }
        public string unirHuellas(string[] marcas)
        {
            for (int i = 0; i < marcas.Length; i++)
            {
                if (marcas[i] != string.Empty && marcas[i] != null)
                {
                    if (i == 0)
                        huellas = marcas[0];
                    else
                        huellas += ',' + marcas[i];
                }
                else
                    huellas += ',';
            }
            return huellas;
        }
        public int cantDedos(string[] marcas)
        {
            int cant = 0;
            for (int i = 0; i < marcas.Length; i++)
            {
                if (marcas[i] != string.Empty && marcas[i] != null)
                    cant++;
            }
            return cant;
        }

        private void GestionarHuella_Shown(object sender, EventArgs e)
        {
            if (flag)
                for (int i = 0; i < grid_personas.Rows.Count; i++)
                    if (Convert.ToInt64(grid_personas.Rows[i].Cells[0].Value.ToString()) == idPersona)
                    {
                        grid_personas.CurrentCell = grid_personas.Rows[i].Cells[1];
                    }
        }

        private void grid_personas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personalBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            permiso = "UsuarioNormal";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            permiso = "UsuarioEnrolador";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            permiso = "UsuarioAdministrador";
        }

        private void Gbox_Dedos_Enter(object sender, EventArgs e)
        {

        }

        private void Cbox_D0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cbox_D1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cbox_D5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
