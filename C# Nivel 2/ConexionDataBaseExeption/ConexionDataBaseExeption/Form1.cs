using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionDataBaseExeption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                a = int.Parse(NumUno_BT.Text);
                b = int.Parse(NumDos_BT.Text);
                r = a + b;
                EtiquetaResultado.Text = "= " + r;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hubo un error");
                //ex.tostring(); me muestra el error completo
            }
            catch (DivideByZeroException ex) 
            {
                MessageBox.Show("No se puede dividir por 0 ");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("exepcion general ");

                throw;//lanzar
            }
            finally 
            { 
                //instrucciones que si o si se van a ejecutar
            }
        }
    }
}
