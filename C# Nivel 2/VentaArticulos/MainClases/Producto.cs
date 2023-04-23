using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClases
{
    public class Producto
    {
        public int CodArticulo { get; set; }
        public float Precio { get; set; }
        private int CodMarca;
        public int CodigoMarca 
        { 
            get { return CodMarca; }
            set 
            {
                if(value >= 1 && value < 11)
                    CodMarca = value;
                else
                    CodMarca = -1;
            }   
        
        }
    }
}
