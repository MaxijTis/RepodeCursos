using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaUnoEntrenamiento
{
    public partial class prbaDisenio : Form
    {
        public prbaDisenio()
        {
            InitializeComponent();
        }

        private void prbaDisenio_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void prbaDisenio_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau, Chau....");
        }

        //private void btnClick_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Se diparo un click " , "Tenga cuidado");
        //    this.BackColor = Color.Blue;
        //}

        
            
        private void lblMax_MouseMove(object sender, MouseEventArgs e)
        {
            lblMax.BackColor = Color.Cyan;
            lblMax.Cursor = Cursors.Hand;


        }

        private void lblMax_MouseLeave(object sender, EventArgs e)
        {
            lblMax.BackColor = System.Drawing.SystemColors.Control;
            lblMax.Cursor = Cursors.Arrow;
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            if(btnTextBox.Text == "") 
            {
                btnTextBox.BackColor = Color.Red;
            }
            else 
            {
                btnTextBox.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void btnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txbSegundo_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene" + txbSegundo.Text.Length + "caracteres.");
        }

        ////private void prbaDisenio_Click(object sender, EventArgs e)
        ////{
        ////    MouseEventArgs click = (MouseEventArgs)e;
        ////    if (click.Button == MouseButtons.Left)
        ////        MessageBox.Show("Presiono el botón Izquierdo", "Atención");
        ////    else if (click.Button == MouseButtons.Right)
        ////        MessageBox.Show("Presiono el Botón Derecho", "Atención");
        ////    else if (click.Button == MouseButtons.Middle)
        ////        MessageBox.Show("Presiono el botón del Medio", "Atención");
        ////}



    }
   }
 
