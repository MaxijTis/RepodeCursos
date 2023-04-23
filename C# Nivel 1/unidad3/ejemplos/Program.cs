using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
         //bloque IF condicionales
        // > < >= <= == != operadores relacionales
        //else if (engancha al la condicion un segundo nivel "sino ,si lalalalal")

        double edad, compra, pagar;

        Console.WriteLine("dame una edad");
        edad = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Dime el monto total");
        compra = double.Parse(Console.ReadLine());

        if(edad > 20){
                 Console.WriteLine("Se aplica un 20% de descuento sobre el total");
                 pagar = compra * 0.8;
                 Console.WriteLine("el total a pagar es $ " + pagar);

            }else{
                 Console.WriteLine("Solo se aplica un 10% de descuento");
                 pagar = compra * 0.9;
                 Console.WriteLine("El total a pagar es " + pagar, "pesos");        

            }


        





        }
    }
}
