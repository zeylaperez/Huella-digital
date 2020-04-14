namespace HuellaDactilar
{
    partial class ConfigurarBD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarBD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4_bd_asis = new System.Windows.Forms.TextBox();
            this.textBox_serv_asis = new System.Windows.Forms.TextBox();
            this.textBox2_pass_asis = new System.Windows.Forms.TextBox();
            this.textBox1_user_asis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox5_bd_grehu = new System.Windows.Forms.TextBox();
            this.textBox6_serv_grehu = new System.Windows.Forms.TextBox();
            this.textBox7_pass_grehu = new System.Windows.Forms.TextBox();
            this.textBox8_user_grehu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4_bd_asis);
            this.panel1.Controls.Add(this.textBox_serv_asis);
            this.panel1.Controls.Add(this.textBox2_pass_asis);
            this.panel1.Controls.Add(this.textBox1_user_asis);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(72, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 249);
            this.panel1.TabIndex = 3;
            // 
            // textBox4_bd_asis
            // 
            this.textBox4_bd_asis.Location = new System.Drawing.Point(122, 95);
            this.textBox4_bd_asis.Name = "textBox4_bd_asis";
            this.textBox4_bd_asis.Size = new System.Drawing.Size(121, 22);
            this.textBox4_bd_asis.TabIndex = 10;
            // 
            // textBox_serv_asis
            // 
            this.textBox_serv_asis.Location = new System.Drawing.Point(122, 43);
            this.textBox_serv_asis.Name = "textBox_serv_asis";
            this.textBox_serv_asis.Size = new System.Drawing.Size(121, 22);
            this.textBox_serv_asis.TabIndex = 9;
            // 
            // textBox2_pass_asis
            // 
            this.textBox2_pass_asis.Location = new System.Drawing.Point(122, 195);
            this.textBox2_pass_asis.Name = "textBox2_pass_asis";
            this.textBox2_pass_asis.PasswordChar = '*';
            this.textBox2_pass_asis.Size = new System.Drawing.Size(121, 22);
            this.textBox2_pass_asis.TabIndex = 8;
            // 
            // textBox1_user_asis
            // 
            this.textBox1_user_asis.Location = new System.Drawing.Point(122, 146);
            this.textBox1_user_asis.Name = "textBox1_user_asis";
            this.textBox1_user_asis.Size = new System.Drawing.Size(121, 22);
            this.textBox1_user_asis.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ususario:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "BD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servidor:";
            this.label2.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajustes BD asistencia";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox5_bd_grehu);
            this.panel2.Controls.Add(this.textBox6_serv_grehu);
            this.panel2.Controls.Add(this.textBox7_pass_grehu);
            this.panel2.Controls.Add(this.textBox8_user_grehu);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(399, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 249);
            this.panel2.TabIndex = 11;
            // 
            // textBox5_bd_grehu
            // 
            this.textBox5_bd_grehu.Location = new System.Drawing.Point(122, 95);
            this.textBox5_bd_grehu.Name = "textBox5_bd_grehu";
            this.textBox5_bd_grehu.Size = new System.Drawing.Size(121, 22);
            this.textBox5_bd_grehu.TabIndex = 10;
            // 
            // textBox6_serv_grehu
            // 
            this.textBox6_serv_grehu.Location = new System.Drawing.Point(122, 43);
            this.textBox6_serv_grehu.Name = "textBox6_serv_grehu";
            this.textBox6_serv_grehu.Size = new System.Drawing.Size(121, 22);
            this.textBox6_serv_grehu.TabIndex = 9;
            // 
            // textBox7_pass_grehu
            // 
            this.textBox7_pass_grehu.Location = new System.Drawing.Point(122, 195);
            this.textBox7_pass_grehu.Name = "textBox7_pass_grehu";
            this.textBox7_pass_grehu.PasswordChar = '*';
            this.textBox7_pass_grehu.Size = new System.Drawing.Size(121, 22);
            this.textBox7_pass_grehu.TabIndex = 8;
            // 
            // textBox8_user_grehu
            // 
            this.textBox8_user_grehu.Location = new System.Drawing.Point(122, 146);
            this.textBox8_user_grehu.Name = "textBox8_user_grehu";
            this.textBox8_user_grehu.Size = new System.Drawing.Size(121, 22);
            this.textBox8_user_grehu.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ususario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "BD:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Servidor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ajustes BD Grehu";
            // 
            // ConfigurarBD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(755, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurarBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigurarBD";
            this.Load += new System.EventHandler(this.ConfigurarBD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2_pass_asis;
        private System.Windows.Forms.TextBox textBox1_user_asis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4_bd_asis;
        private System.Windows.Forms.TextBox textBox_serv_asis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox5_bd_grehu;
        private System.Windows.Forms.TextBox textBox6_serv_grehu;
        private System.Windows.Forms.TextBox textBox7_pass_grehu;
        private System.Windows.Forms.TextBox textBox8_user_grehu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}