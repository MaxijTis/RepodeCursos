namespace EjemploDateTime
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
            this.CalFecha = new System.Windows.Forms.MonthCalendar();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.Prueba1 = new System.Windows.Forms.Button();
            this.prueba2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalFecha
            // 
            this.CalFecha.Location = new System.Drawing.Point(112, 157);
            this.CalFecha.Name = "CalFecha";
            this.CalFecha.TabIndex = 0;
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(122, 102);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 20);
            this.dtPicker.TabIndex = 1;
            // 
            // Prueba1
            // 
            this.Prueba1.Location = new System.Drawing.Point(501, 98);
            this.Prueba1.Name = "Prueba1";
            this.Prueba1.Size = new System.Drawing.Size(75, 23);
            this.Prueba1.TabIndex = 2;
            this.Prueba1.Text = "Prueba";
            this.Prueba1.UseVisualStyleBackColor = true;
            this.Prueba1.Click += new System.EventHandler(this.Prueba1_Click);
            // 
            // prueba2
            // 
            this.prueba2.Location = new System.Drawing.Point(501, 157);
            this.prueba2.Name = "prueba2";
            this.prueba2.Size = new System.Drawing.Size(75, 23);
            this.prueba2.TabIndex = 3;
            this.prueba2.Text = "Prueba 2";
            this.prueba2.UseVisualStyleBackColor = true;
            this.prueba2.Click += new System.EventHandler(this.prueba2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prueba2);
            this.Controls.Add(this.Prueba1);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.CalFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalFecha;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button Prueba1;
        private System.Windows.Forms.Button prueba2;
    }
}

