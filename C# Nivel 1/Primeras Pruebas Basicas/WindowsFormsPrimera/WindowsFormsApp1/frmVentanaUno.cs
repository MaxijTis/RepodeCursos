using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmVentanaUno : Form
    {
        public frmVentanaUno()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String texto = txtNombre.Text;
            lblSaludo.Text = "Hola " + texto;
        }
        private void frmVentanaUno_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a mi app..");
        }
        private void frmVentanaUno_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias por utilizar la app :)");
        }
    }
}
