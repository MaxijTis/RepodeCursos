using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contadorTotal = 0;
            int contadorPrimo = 0;
            int promedio;
            int acuPrimo = 0;

        Console.WriteLine("Ingrese un numero ");
        numero = int.Parse(Console.ReadLine());

            while(numero != 0)
            {
                contadorTotal++;

                if(primo(numero) == 1){
                    contadorPrimo++;
                    acuPrimo += numero;
                }

                Console.WriteLine("Ingrese un numero ");
                numero = int.Parse(Console.ReadLine());

            }

            promedio = acuPrimo / contadorPrimo;

            Console.WriteLine("El promedio de los numeros primos es " + promedio);
        }

        
        
        
        
     static int primo(int a){
            int  r;
            int cont = 0;

           for (int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                {
                    cont++;
                }
            }
                if(cont == 2)
                {
                    r = 1;
                }else{
                    r = 0;
                }
        
            return r;
        }

    }
}
