namespace ConexionDataBaseExeption
{
    partial class Form1
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
            this.NumUno_BT = new System.Windows.Forms.TextBox();
            this.NumDos_BT = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.EtiquetaResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumUno_BT
            // 
            this.NumUno_BT.Location = new System.Drawing.Point(150, 49);
            this.NumUno_BT.Name = "NumUno_BT";
            this.NumUno_BT.Size = new System.Drawing.Size(170, 20);
            this.NumUno_BT.TabIndex = 0;
            // 
            // NumDos_BT
            // 
            this.NumDos_BT.Location = new System.Drawing.Point(150, 112);
            this.NumDos_BT.Name = "NumDos_BT";
            this.NumDos_BT.Size = new System.Drawing.Size(170, 20);
            this.NumDos_BT.TabIndex = 1;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(196, 164);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 2;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // EtiquetaResultado
            // 
            this.EtiquetaResultado.AutoSize = true;
            this.EtiquetaResultado.Location = new System.Drawing.Point(229, 209);
            this.EtiquetaResultado.Name = "EtiquetaResultado";
            this.EtiquetaResultado.Size = new System.Drawing.Size(13, 13);
            this.EtiquetaResultado.TabIndex = 3;
            this.EtiquetaResultado.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 231);
            this.Controls.Add(this.EtiquetaResultado);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.NumDos_BT);
            this.Controls.Add(this.NumUno_BT);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumUno_BT;
        private System.Windows.Forms.TextBox NumDos_BT;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label EtiquetaResultado;
    }
}

