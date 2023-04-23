namespace MainProyect
{
    partial class frmMelómano
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVDiscos = new System.Windows.Forms.DataGridView();
            this.PBXTapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDiscos
            // 
            this.DGVDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDiscos.Location = new System.Drawing.Point(12, 12);
            this.DGVDiscos.Name = "DGVDiscos";
            this.DGVDiscos.Size = new System.Drawing.Size(551, 229);
            this.DGVDiscos.TabIndex = 0;
            
            // 
            // PBXTapa
            // 
            this.PBXTapa.Location = new System.Drawing.Point(581, 12);
            this.PBXTapa.Name = "PBXTapa";
            this.PBXTapa.Size = new System.Drawing.Size(207, 229);
            this.PBXTapa.TabIndex = 1;
            this.PBXTapa.TabStop = false;
            // 
            // frmMelómano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.PBXTapa);
            this.Controls.Add(this.DGVDiscos);
            this.Name = "frmMelómano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Melómano";
            this.Load += new System.EventHandler(this.Melómano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXTapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDiscos;
        private System.Windows.Forms.PictureBox PBXTapa;
    }
}

