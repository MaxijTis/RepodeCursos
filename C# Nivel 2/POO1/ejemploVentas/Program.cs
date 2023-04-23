using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploVentas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Primer lote con 10 registros de productos, cada producto tiene:
            //              - codigo de articulo(3 digitos no correlativos)
            //              - Precio
            //              - Codigo de marca(1 al 10)
            //
            //            Segundo lote con las ventas de la semana cada venta tiene
            //              - Codigo de articulo
            //              - Cantidad
            //              - Codigo de cliente(1 a 100)
            //              Este lote corta con codigo de cliente 0.

            //Producto a1 = new Producto();
            //a1.codArticulo = 20;  (Si lo haria asi deberia cargar 10 articulos
            //es mejor con un vector)

            Producto[] productos = new Producto[10];
            // ejemplo productos[5].codArticulo = 6;

            for(int x = 0; x < 10; x++) 
            {
                productos[x] = new Producto();  
                Console.WriteLine("Ingrese los datos del articulo: ");
                Console.WriteLine("Codigo: ");
                productos[x].codArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("precio: ");
                productos[x].precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca: (Solo del 1 a 10)");
                productos[x].CodigoMarca = int.Parse(Console.ReadLine());

                //Cargado el vector con 10 articulos
                

            }
            Venta venta = new Venta();

            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Codigo de cliente: ");
            venta.codCliente = int.Parse(Console.ReadLine());


            while (venta.codCliente != 0) 
            { 
                Console.WriteLine("Codigo articulo ");
                venta.codigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Codigo de cliente: ");
                venta.codCliente = int.Parse(Console.ReadLine());
            }


            Console.ReadKey();


        }
    }
}
