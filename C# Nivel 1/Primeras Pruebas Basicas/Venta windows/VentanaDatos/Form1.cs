using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaDatos
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string upperApellido = apellido.ToUpper();
            string nombre = txtNombre.Text;
            string upperNombre = nombre.ToUpper();
            string edad = txtEdad.Text;
            string direccion = txtDireccion.Text;


            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
            }
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
            }
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
            }

            lvElementos.Items.Add("Apellido y nombre: " + upperApellido + " , " + upperNombre);
            lvElementos.Items.Add("Edad: " + edad);
            lvElementos.Items.Add("Dirección: " + direccion);

        }
        //private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        //         (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }   
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


       
    
