namespace pruebaUnoEntrenamiento
{
    partial class prbaDisenio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prbaDisenio));
            this.btnClick = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnTextBox = new System.Windows.Forms.TextBox();
            this.txbSegundo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.Image = ((System.Drawing.Image)(resources.GetObject("btnClick.Image")));
            this.btnClick.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClick.Location = new System.Drawing.Point(57, 113);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(112, 23);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Haceme Click";
            this.btnClick.UseVisualStyleBackColor = false;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMax.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.Navy;
            this.lblMax.Location = new System.Drawing.Point(206, 52);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(80, 17);
            this.lblMax.TabIndex = 1;
            this.lblMax.Tag = "Un simple boton";
            this.lblMax.Text = "Solo un Label";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMax.MouseLeave += new System.EventHandler(this.lblMax_MouseLeave);
            this.lblMax.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMax_MouseMove);
            // 
            // btnTextBox
            // 
            this.btnTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.btnTextBox.Location = new System.Drawing.Point(358, 136);
            this.btnTextBox.MaxLength = 333333;
            this.btnTextBox.Name = "btnTextBox";
            this.btnTextBox.Size = new System.Drawing.Size(100, 20);
            this.btnTextBox.TabIndex = 3;
            this.btnTextBox.Click += new System.EventHandler(this.btnTextBox_Click);
            this.btnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnTextBox_KeyPress);
            // 
            // txbSegundo
            // 
            this.txbSegundo.Location = new System.Drawing.Point(69, 182);
            this.txbSegundo.Multiline = true;
            this.txbSegundo.Name = "txbSegundo";
            this.txbSegundo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbSegundo.Size = new System.Drawing.Size(178, 174);
            this.txbSegundo.TabIndex = 4;
            this.txbSegundo.Leave += new System.EventHandler(this.txbSegundo_Leave);
            // 
            // prbaDisenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSegundo);
            this.Controls.Add(this.btnTextBox);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.btnClick);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "prbaDisenio";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa de Maxi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.prbaDisenio_FormClosed);
            this.Load += new System.EventHandler(this.prbaDisenio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox btnTextBox;
        private System.Windows.Forms.TextBox txbSegundo;
    }
}

