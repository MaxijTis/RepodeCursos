using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio = 0, cantidad = 0;
            int totalApagar;

            pedirDatos(ref precio, ref cantidad);
            totalApagar = producto(precio, cantidad);

            Console.WriteLine("El precio total a pagar es $" + totalApagar);
        }


        static void pedirDatos(ref int a, ref int b)
        {
            Console.WriteLine("Ingrese el precio del producto ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad comprada ");
            b = int.Parse(Console.ReadLine());
        }

        static int producto(int a, int b)
        {
            int r;
            r = a * b;
            return r;
        }
    }
}
