namespace HuellaDactilar
{
    partial class AddHuella
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHuella));
            this.picFPImg = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.btn_Desconectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picFPImg
            // 
            this.picFPImg.Location = new System.Drawing.Point(29, 60);
            this.picFPImg.Margin = new System.Windows.Forms.Padding(4);
            this.picFPImg.Name = "picFPImg";
            this.picFPImg.Size = new System.Drawing.Size(219, 246);
            this.picFPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFPImg.TabIndex = 0;
            this.picFPImg.TabStop = false;
            this.picFPImg.Click += new System.EventHandler(this.Img_Huella_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(275, 228);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(100, 28);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Atras";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Location = new System.Drawing.Point(29, 25);
            this.btn_Conectar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(100, 28);
            this.btn_Conectar.TabIndex = 4;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // btn_Desconectar
            // 
            this.btn_Desconectar.Enabled = false;
            this.btn_Desconectar.Location = new System.Drawing.Point(137, 25);
            this.btn_Desconectar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Desconectar.Name = "btn_Desconectar";
            this.btn_Desconectar.Size = new System.Drawing.Size(111, 28);
            this.btn_Desconectar.TabIndex = 5;
            this.btn_Desconectar.Text = "Desconectar";
            this.btn_Desconectar.UseVisualStyleBackColor = true;
            this.btn_Desconectar.Click += new System.EventHandler(this.btn_Desconectar_Click);
            // 
            // AddHuella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(396, 343);
            this.Controls.Add(this.btn_Desconectar);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.picFPImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddHuella";
            this.Text = "Agregar huella";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddHuella_FormClosing);
            this.Load += new System.EventHandler(this.AddHuella_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFPImg;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.Button btn_Desconectar;
    }
}