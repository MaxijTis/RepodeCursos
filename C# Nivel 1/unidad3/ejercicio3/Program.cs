using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double compra;

            Console.WriteLine("Ingrese el monto de la compra: ");
            compra = double.Parse(Console.ReadLine());

            if(compra < 1000){
                Console.WriteLine("No hay descuento");
            }else if(compra > 999 && compra < 5000){
                compra = compra * 0.9;
                Console.WriteLine("Tiene un 10% de descuento");
                Console.WriteLine("Va a pagar " + compra);
            }else{
                compra = compra * 0.82;
                Console.WriteLine("Tiene un 18% de descuento");
                Console.WriteLine("Va a pagar " + compra);
            }
        }
    }
}
