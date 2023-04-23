using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploVentas
{
    internal class Producto
    {
        
        public int codArticulo { get; set; }    

        public float precio { get; set; }

        //(Este es el atributo)
        public int CodigoMarca //(esta es la propiedad)
        {
            get { return CodigoMarca; }
            set
            {
                if(value > 0 && value < 11)
                CodigoMarca = value;
                else
                CodigoMarca = -1;
            }
        }
    }
}
