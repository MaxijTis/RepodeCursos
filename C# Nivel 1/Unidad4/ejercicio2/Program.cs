using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int importe, litros; 
            double importefinal;

            Console.WriteLine("Ingrese el importe de su compra: ");
            importe = int.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese los litros que compro: ");
            litros = int.Parse(Console.ReadLine());

            if(litros < 100){
                Console.WriteLine("No tiene descuento, sun importe a pagar es " + importe);
            }

            if(litros > 100 && litros < 300){
                importefinal = importe * 0.90;
                Console.WriteLine("Tiene un 10% de descuento, su importe a pagar es: " + importefinal );
            }
            
            if(litros > 300 && litros < 500){
                importefinal = importe * 0.85;
                Console.WriteLine("Tiene un 15% de descuento, su importe a pagar es " + importefinal);
            }

            if(litros > 500){
                importefinal = importe * 0.75;
                Console.WriteLine("Tiene un 25% de descuento, su importe a pagar es " + importefinal);
            }


            Console.WriteLine("Presione Enter para finalizar el programa");
            Console.ReadLine();
        }
    }
}
