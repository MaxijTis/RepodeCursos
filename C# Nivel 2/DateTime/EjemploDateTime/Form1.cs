using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Prueba1_Click(object sender, EventArgs e)
        {
            DateTime fecha1;
            fecha1 = dtPicker.Value;
            MessageBox.Show("La fecha seleccionada es " + fecha1.ToString("dd/MM/yy"));



        }

        private void prueba2_Click(object sender, EventArgs e)
        {
            
            
            
            MessageBox.Show("La fecha seleccionada es " + CalFecha.SelectionStart.ToString("dd/MM/yy"));


        }
    }
}
