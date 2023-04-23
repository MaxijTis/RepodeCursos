using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           //3. Hacer un programa para recibir listas de números positivos 
           //que están separadas entre sí por un cero. 
           //El fin de la carga se notifica con un número negativo. 
           //Luego mostrar cuántos números tiene cada lista.


            int n;
            int cont = 0, numeroGrupo = 0;

            Console.WriteLine("Ingresa un numero");
            n = int.Parse(Console.ReadLine());

           while(n >= 0){
               numeroGrupo++;
               cont = 0;
               while(n > 0){
                   cont++;

                Console.WriteLine("Ingresa un numero");
                n = int.Parse(Console.ReadLine());

               }

               Console.WriteLine("Del grupo " + numeroGrupo + " hay " + cont + " numeros.");

                n = int.Parse(Console.ReadLine());
           }
        }
    }
}
