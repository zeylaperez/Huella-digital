namespace HuellaDactilar
{
    partial class GestionarHuella
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarHuella));
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.grid_personas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbox_D0 = new System.Windows.Forms.CheckBox();
            this.cbox_D1 = new System.Windows.Forms.CheckBox();
            this.cbox_D2 = new System.Windows.Forms.CheckBox();
            this.cbox_D3 = new System.Windows.Forms.CheckBox();
            this.cbox_D4 = new System.Windows.Forms.CheckBox();
            this.cbox_D5 = new System.Windows.Forms.CheckBox();
            this.cbox_D6 = new System.Windows.Forms.CheckBox();
            this.cbox_D7 = new System.Windows.Forms.CheckBox();
            this.cbox_D8 = new System.Windows.Forms.CheckBox();
            this.cbox_D9 = new System.Windows.Forms.CheckBox();
            this.gbox_Dedos = new System.Windows.Forms.GroupBox();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelojes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_trabajador = new System.Windows.Forms.Label();
            this.lbl_cantDedos = new System.Windows.Forms.Label();
            this.lbl_msgCantDedos = new System.Windows.Forms.Label();
            this.img_manos = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.numtarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grehu_etiDataSet = new HuellaDactilar.grehu_etiDataSet();
            this.personalTableAdapter = new HuellaDactilar.grehu_etiDataSetTableAdapters.personalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid_personas)).BeginInit();
            this.gbox_Dedos.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_manos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grehu_etiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.AccessibleName = "";
            this.txt_Buscar.Location = new System.Drawing.Point(16, 37);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(433, 22);
            this.txt_Buscar.TabIndex = 0;
            this.txt_Buscar.Tag = "";
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // grid_personas
            // 
            this.grid_personas.AllowUserToAddRows = false;
            this.grid_personas.AllowUserToDeleteRows = false;
            this.grid_personas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_personas.AutoGenerateColumns = false;
            this.grid_personas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_personas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grid_personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_personas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.numtarjetaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.apellidos});
            this.grid_personas.DataSource = this.personalBindingSource;
            this.grid_personas.Location = new System.Drawing.Point(16, 69);
            this.grid_personas.Margin = new System.Windows.Forms.Padding(4);
            this.grid_personas.MultiSelect = false;
            this.grid_personas.Name = "grid_personas";
            this.grid_personas.ReadOnly = true;
            this.grid_personas.RowHeadersWidth = 51;
            this.grid_personas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_personas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_personas.Size = new System.Drawing.Size(432, 466);
            this.grid_personas.TabIndex = 1;
            this.grid_personas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_personas_CellClick);
            this.grid_personas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_personas_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id_persona";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "apellidos";
            this.apellidos.HeaderText = "apellidos";
            this.apellidos.MinimumWidth = 6;
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            // 
            // cbox_D0
            // 
            this.cbox_D0.AutoSize = true;
            this.cbox_D0.Location = new System.Drawing.Point(32, 34);
            this.cbox_D0.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_D0.Name = "cbox_D0";
            this.cbox_D0.Size = new System.Drawing.Size(76, 21);
            this.cbox_D0.TabIndex = 3;
            this.cbox_D0.Text = "Dedo 0";
            this.cbox_D0.UseVisualStyleBackColor = true;
            this.cbox_D0.CheckedChanged += new System.EventHandler(this.Cbox_D0_CheckedChanged);
            this.cbox_D0.Click += new System.EventHandler(this.cbox_D0_Click);
            // 
            // cbox_D1
            // 
            this.cbox_D1.AutoSize = true;
            this.cbox_D1.Location = new System.Drawing.Point(32, 63);
            this.cbox_D1.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_D1.Name = "cbox_D1";
            this.cbox_D1.Size = new System.Drawing.Size(76, 21);
            this.cbox_D1.TabIndex = 4;
            this.cbox_D1.Text = "Dedo 1";
            this.cbox_D1.UseVisualStyleBackColor = true;
            this.cbox_D1.CheckedChanged += new System.EventHandler(this.Cbox_D1_CheckedChanged);
            this.cbox_D1.Click += new System.EventHandler(this.cbox_D1_Click);
            // 
            // cbox_D2
            // 
            this.cbox_D2.AutoSize = true;
            this.cbox_D2.Location = new System.Drawing.Point(32, 91);
            this.cbox_D2.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_D2.Name = "cbox_D2";
            this.cbox_D2.Size = new System.Drawing.Size(76, 21);
            this.cbox_D2.TabIndex = 5;
            this.cbox_D2.Text = "Dedo 2";
            this.cbox_D2.UseVisualStyleBackColor = true;
            this.cbox_D2.Click += new System.EventHandler(this.cbox_D2_Click);
            // 
            // cbox_D3
            // 
            this.cbox_D3.AutoSize = true;
            this.cbox_D3.Location = new System.Drawing.Point(32, 119);
            this.cbox_D3.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_D3.Name = "cbox_D3";
            this.cbox_D3.Size = new System.Drawing.Size(76, 21);
            this.cbox_D3.TabIndex = 6;
            this.cbox_D3.Text = "Dedo 3";
            this.cbox_D3.UseVisualStyleBackColor = true;
            this.cbox_D3.Click += new System.EventHandler(this.cbox_D3_Click);
            // 
            // cbox_D4
            // 
            this.cbox_D4.AutoSize = true;
            this.cbox_D4.Location = new System.Drawing.Point(32, 148);
            this.cbox_D4.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_D4.Name = "cbox_D4";
            this.cbox_D4.Size = new System.Drawing.Size(76, 21);
            this.cbox_D4.TabIndex = 7;
            this.cbox_D4.Text = "Dedo 4";
            this.cbox_D4.UseVisualStyleBackColor = true;
            this.cbox_D4.Click += new System.EventHandler(this.cbox_D4_Click);
            // 
            // cbox_D5
            // 
            this.cbox_D5.AutoSize = true;
            this.cbox_D5.Location = new System.Drawing.Point(175, 34);
            this.cbox_D5.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_D5.Name = "cbox_D5";
            this.cbox_D5.Size = new System.Drawing.Size(76, 21);
            this.cbox_D5.TabIndex = 8;
            this.cbox_D5.Text = "Dedo 5";
            this.cbox_D5.UseVisualStyleBackColor = true;
            this.cbox_D5.Click += new System.EventHandler(this.cbox_D5_Click);
            // 
            // cbox_D6
            // 
            this.cbox_D6.AutoSize = true;
            this.cbox_D6.Location = new System.Drawing.Point(175, 63);
            this.cbox_D6.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_D6.Name = "cbox_D6";
            this.cbox_D6.Size = new System.Drawing.Size(76, 21);
            this.cbox_D6.TabIndex = 9;
            this.cbox_D6.Text = "Dedo 6";
            this.cbox_D6.UseVisualStyleBackColor = true;
            this.cbox_D6.Click += new System.EventHandler(this.cbox_D6_Click);
            // 
            // cbox_D7
            // 
            this.cbox_D7.AutoSize = true;
            this.cbox_D7.Location = new System.Drawing.Point(175, 91);
            this.cbox_D7.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_D7.Name = "cbox_D7";
            this.cbox_D7.Size = new System.Drawing.Size(76, 21);
            this.cbox_D7.TabIndex = 10;
            this.cbox_D7.Text = "Dedo 7";
            this.cbox_D7.UseVisualStyleBackColor = true;
            this.cbox_D7.Click += new System.EventHandler(this.cbox_D7_Click);
            // 
            // cbox_D8
            // 
            this.cbox_D8.AutoSize = true;
            this.cbox_D8.Location = new System.Drawing.Point(175, 119);
            this.cbox_D8.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_D8.Name = "cbox_D8";
            this.cbox_D8.Size = new System.Drawing.Size(76, 21);
            this.cbox_D8.TabIndex = 11;
            this.cbox_D8.Text = "Dedo 8";
            this.cbox_D8.UseVisualStyleBackColor = true;
            this.cbox_D8.Click += new System.EventHandler(this.cbox_D8_Click);
            // 
            // cbox_D9
            // 
            this.cbox_D9.AutoSize = true;
            this.cbox_D9.Location = new System.Drawing.Point(175, 148);
            this.cbox_D9.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_D9.Name = "cbox_D9";
            this.cbox_D9.Size = new System.Drawing.Size(76, 21);
            this.cbox_D9.TabIndex = 12;
            this.cbox_D9.Text = "Dedo 9";
            this.cbox_D9.UseVisualStyleBackColor = true;
            this.cbox_D9.Click += new System.EventHandler(this.cbox_D9_Click);
            // 
            // gbox_Dedos
            // 
            this.gbox_Dedos.BackColor = System.Drawing.Color.Transparent;
            this.gbox_Dedos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbox_Dedos.Controls.Add(this.cbox_D5);
            this.gbox_Dedos.Controls.Add(this.cbox_D9);
            this.gbox_Dedos.Controls.Add(this.cbox_D0);
            this.gbox_Dedos.Controls.Add(this.cbox_D8);
            this.gbox_Dedos.Controls.Add(this.cbox_D1);
            this.gbox_Dedos.Controls.Add(this.cbox_D7);
            this.gbox_Dedos.Controls.Add(this.cbox_D2);
            this.gbox_Dedos.Controls.Add(this.cbox_D6);
            this.gbox_Dedos.Controls.Add(this.cbox_D3);
            this.gbox_Dedos.Controls.Add(this.cbox_D4);
            this.gbox_Dedos.Location = new System.Drawing.Point(659, 71);
            this.gbox_Dedos.Margin = new System.Windows.Forms.Padding(4);
            this.gbox_Dedos.Name = "gbox_Dedos";
            this.gbox_Dedos.Padding = new System.Windows.Forms.Padding(4);
            this.gbox_Dedos.Size = new System.Drawing.Size(301, 185);
            this.gbox_Dedos.TabIndex = 13;
            this.gbox_Dedos.TabStop = false;
            this.gbox_Dedos.Text = "Dedos";
            this.gbox_Dedos.Visible = false;
            this.gbox_Dedos.Enter += new System.EventHandler(this.Gbox_Dedos_Enter);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInicio,
            this.menuRelojes,
            this.menuSalir});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(1036, 28);
            this.menuPrincipal.TabIndex = 17;
            // 
            // menuInicio
            // 
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(59, 24);
            this.menuInicio.Text = "Inicio";
            this.menuInicio.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // menuRelojes
            // 
            this.menuRelojes.Name = "menuRelojes";
            this.menuRelojes.Size = new System.Drawing.Size(71, 24);
            this.menuRelojes.Text = "Relojes";
            this.menuRelojes.Click += new System.EventHandler(this.menuRelojes_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(52, 24);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lbl_trabajador
            // 
            this.lbl_trabajador.AutoSize = true;
            this.lbl_trabajador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_trabajador.Location = new System.Drawing.Point(492, 50);
            this.lbl_trabajador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trabajador.Name = "lbl_trabajador";
            this.lbl_trabajador.Size = new System.Drawing.Size(61, 17);
            this.lbl_trabajador.TabIndex = 22;
            this.lbl_trabajador.Text = "Persona";
            this.lbl_trabajador.Visible = false;
            // 
            // lbl_cantDedos
            // 
            this.lbl_cantDedos.AutoSize = true;
            this.lbl_cantDedos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantDedos.Location = new System.Drawing.Point(845, 260);
            this.lbl_cantDedos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantDedos.Name = "lbl_cantDedos";
            this.lbl_cantDedos.Size = new System.Drawing.Size(74, 17);
            this.lbl_cantDedos.TabIndex = 23;
            this.lbl_cantDedos.Text = "IDPersona";
            this.lbl_cantDedos.Visible = false;
            // 
            // lbl_msgCantDedos
            // 
            this.lbl_msgCantDedos.AutoSize = true;
            this.lbl_msgCantDedos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msgCantDedos.Location = new System.Drawing.Point(716, 260);
            this.lbl_msgCantDedos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_msgCantDedos.Name = "lbl_msgCantDedos";
            this.lbl_msgCantDedos.Size = new System.Drawing.Size(131, 17);
            this.lbl_msgCantDedos.TabIndex = 24;
            this.lbl_msgCantDedos.Text = "Cantidad de dedos:";
            this.lbl_msgCantDedos.Visible = false;
            // 
            // img_manos
            // 
            this.img_manos.BackColor = System.Drawing.Color.Transparent;
            this.img_manos.Image = ((System.Drawing.Image)(resources.GetObject("img_manos.Image")));
            this.img_manos.Location = new System.Drawing.Point(645, 318);
            this.img_manos.Margin = new System.Windows.Forms.Padding(4);
            this.img_manos.Name = "img_manos";
            this.img_manos.Size = new System.Drawing.Size(331, 151);
            this.img_manos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_manos.TabIndex = 25;
            this.img_manos.TabStop = false;
            this.img_manos.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(495, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(142, 185);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permiso";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 91);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(116, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Administrador";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Enrolador";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Usuario";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // numtarjetaDataGridViewTextBoxColumn
            // 
            this.numtarjetaDataGridViewTextBoxColumn.DataPropertyName = "num_tarjeta";
            this.numtarjetaDataGridViewTextBoxColumn.HeaderText = "num_tarjeta";
            this.numtarjetaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numtarjetaDataGridViewTextBoxColumn.Name = "numtarjetaDataGridViewTextBoxColumn";
            this.numtarjetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "personal";
            this.personalBindingSource.DataSource = this.grehu_etiDataSet;
            this.personalBindingSource.CurrentChanged += new System.EventHandler(this.personalBindingSource_CurrentChanged);
            // 
            // grehu_etiDataSet
            // 
            this.grehu_etiDataSet.DataSetName = "grehu_etiDataSet";
            this.grehu_etiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // GestionarHuella
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1036, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.img_manos);
            this.Controls.Add(this.lbl_msgCantDedos);
            this.Controls.Add(this.lbl_cantDedos);
            this.Controls.Add(this.lbl_trabajador);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.gbox_Dedos);
            this.Controls.Add(this.grid_personas);
            this.Controls.Add(this.txt_Buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GestionarHuella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Huellas Digitales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionarHuella_FormClosing);
            this.Load += new System.EventHandler(this.GestionarHuella_Load);
            this.Shown += new System.EventHandler(this.GestionarHuella_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grid_personas)).EndInit();
            this.gbox_Dedos.ResumeLayout(false);
            this.gbox_Dedos.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_manos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grehu_etiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.DataGridView grid_personas;
        private System.Windows.Forms.CheckBox cbox_D0;
        private System.Windows.Forms.CheckBox cbox_D1;
        private System.Windows.Forms.CheckBox cbox_D2;
        private System.Windows.Forms.CheckBox cbox_D3;
        private System.Windows.Forms.CheckBox cbox_D4;
        private System.Windows.Forms.CheckBox cbox_D5;
        private System.Windows.Forms.CheckBox cbox_D6;
        private System.Windows.Forms.CheckBox cbox_D7;
        private System.Windows.Forms.CheckBox cbox_D8;
        private System.Windows.Forms.CheckBox cbox_D9;
        private System.Windows.Forms.GroupBox gbox_Dedos;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private grehu_etiDataSet grehu_etiDataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private grehu_etiDataSetTableAdapters.personalTableAdapter personalTableAdapter;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuInicio;
        private System.Windows.Forms.ToolStripMenuItem menuRelojes;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.Label lbl_trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.Label lbl_cantDedos;
        private System.Windows.Forms.Label lbl_msgCantDedos;
        private System.Windows.Forms.PictureBox img_manos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}