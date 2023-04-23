using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            


            //4. Una empresa comercializa 15 tipos de artículos y 
            //por cada venta realizada genera un registro con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 

            //Puede haber varios registros para el mismo artículo y 
            //el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.

         
            int cantidad;
            int articulo;
            int[] cantidadVendida = new int[15]; 
            int maxCantidad;

            for (int x = 0; x < 15; x++)
            {
                cantidadVendida[x] = 0;
            }
            
                Console.WriteLine("Ingresa el nro de articulo");
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la cantidad vendida ");
                cantidad = int.Parse(Console.ReadLine());

            while(articulo != 0)
            {
                cantidadVendida[articulo - 1] += cantidad;
                
                Console.WriteLine("Ingresa el nro de articulo");
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la cantidad vendida ");
                cantidad = int.Parse(Console.ReadLine());
            }

            maxCantidad = cantidadVendida[0];

            for (int x = 0; x < 15; x++)
            {
                if(maxCantidad < cantidadVendida[x]){
                    maxCantidad = cantidadVendida[x];
                    articulo = x + 1;
                }
                
            }

            for (int x = 0; x < 15; x++)
            {
                if(cantidadVendida[x] == 0){
                    Console.WriteLine("El producto " + (x + 1) + " No tuvo ventas " );
                }
            }


            Console.WriteLine("El articulo mas vendido es: " + articulo + " con la cantidad de " + maxCantidad);
            Console.WriteLine("El articulo 10 tuvo " + cantidadVendida[10]);

        }
    }
}
