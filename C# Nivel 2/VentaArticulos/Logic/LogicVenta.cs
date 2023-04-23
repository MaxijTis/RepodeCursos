using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainClases;

namespace Logic
{
    class LogicVenta
    { 
        static void Main(string[] args) 
        {
            Producto[] productos = new Producto[10];  
            for (int x = 0; x<10; x++)
			{
                productos[x] = new Producto();
                productos[x].CodArticulo = int.Parse(Console.ReadLine());
                productos[x].CodigoMarca = int.Parse(Console.ReadLine());
                productos[x].Precio = int.Parse(Console.ReadLine());
            }
            Venta ventas = new Venta();
            ventas.codCliente = int.Parse(Console.ReadLine());
            while (ventas.codCliente != 0)
            {
                ventas.codigoArticulo = int.Parse(Console.ReadLine());  
                ventas.Cantidad = int.Parse(Console.ReadLine());
                ventas.codCliente = int.Parse(Console.ReadLine());
            }
	    }
    }
}
