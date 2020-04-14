namespace HuellaDactilar
{
    partial class Relojes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relojes));
            this.grid_relojes = new System.Windows.Forms.DataGridView();
            this.btn_sincronizar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.grid_relojes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_relojes
            // 
            this.grid_relojes.AllowUserToAddRows = false;
            this.grid_relojes.AllowUserToDeleteRows = false;
            this.grid_relojes.AllowUserToResizeColumns = false;
            this.grid_relojes.AllowUserToResizeRows = false;
            this.grid_relojes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_relojes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grid_relojes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_relojes.Location = new System.Drawing.Point(56, 38);
            this.grid_relojes.Margin = new System.Windows.Forms.Padding(4);
            this.grid_relojes.Name = "grid_relojes";
            this.grid_relojes.ReadOnly = true;
            this.grid_relojes.RowHeadersWidth = 51;
            this.grid_relojes.Size = new System.Drawing.Size(471, 151);
            this.grid_relojes.TabIndex = 0;
            this.grid_relojes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_relojes_CellContentClick);
            // 
            // btn_sincronizar
            // 
            this.btn_sincronizar.Location = new System.Drawing.Point(231, 256);
            this.btn_sincronizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sincronizar.Name = "btn_sincronizar";
            this.btn_sincronizar.Size = new System.Drawing.Size(107, 28);
            this.btn_sincronizar.TabIndex = 2;
            this.btn_sincronizar.Text = "Sincronizar";
            this.btn_sincronizar.UseVisualStyleBackColor = true;
            this.btn_sincronizar.Click += new System.EventHandler(this.btn_sincronizar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(84, 217);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(407, 17);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Relojes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(592, 297);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_sincronizar);
            this.Controls.Add(this.grid_relojes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Relojes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relojes";
            this.Load += new System.EventHandler(this.Relojes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_relojes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_relojes;
        private System.Windows.Forms.Button btn_sincronizar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}