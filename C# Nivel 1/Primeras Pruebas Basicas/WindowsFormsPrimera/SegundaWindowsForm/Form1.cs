using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
        }
        private void btnVerperfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechanac = dtpFechaNacimiento.Value;
            string chocolate = chbChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string tipo;
            if (rbtWizard.Checked) 
            { 
                tipo = "Es Wizard";
            }
            else if (rbtMaggle.Checked) 
            { 
                tipo = "Es maggle";
            }
            else 
            { 
                tipo = "Es Squibbs";
            }
            String colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();
            string mensaje = "Su nombre es " + nombre + ", su fecha de nacimiento fue " + fechanac.ToShortDateString() + " , " + chocolate  + ", " + tipo + ", Su color favorito es " + colorFavorito + ", " + "Su numero favorito es " + numeroFavorito + ".";
            LvElementos.Text = mensaje;
        }

    }
}
