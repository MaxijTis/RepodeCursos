using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Telefono t1 = new Telefono("s2", "samsung");
            Console.WriteLine("Bienvenido al programa telefono...");
            Console.WriteLine("Ingrese el codigo de operador: ");
            t1.CodOperador = int.Parse(Console.ReadLine());

            if(t1.CodOperador != 0) {
                Console.WriteLine("Ingrese el numero de telefono(Sin el codigo de area)");
                t1.NumeroTelefonico = int.Parse(Console.ReadLine());
            }else{
                Console.WriteLine("Numero de operador inexistente");
            }

            Console.WriteLine(t1.Llamar());
            Console.WriteLine(t1.Llamar("Maxi"));


            Console.ReadKey();


        }
    }
}
