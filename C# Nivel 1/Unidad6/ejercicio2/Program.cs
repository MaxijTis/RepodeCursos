using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           //2. Se dispone de una lista de 5 listas de números enteros separados entre 
           //ellos por ceros. Se pide determinar e informar:

           //*El número de grupo con mayor porcentaje de números impares 
           //respecto al total de números que forman el grupo.
           //*Informar cuántos grupos están formados por todos 
           //números ordenados de mayor a menor.

            int n, porcentajeMaximo = 0;
            int contImp = 0, contTotal = 0, grupo = 0;
            int porcentaje;

            for(int x = 0; x < 5; x++){
            contTotal = 0;
            contImp = 0;
            Console.WriteLine("Ingrese un numero ");
                n = int.Parse(Console.ReadLine());
                contTotal++;

                while(n != 0){
                    if(n % 2 != 0){
                        contImp++;
                    }
                    Console.WriteLine("Ingrese otros numeros ");
                    n = int.Parse(Console.ReadLine());
                }
                porcentaje = contImp * 100 / contTotal;

            if(porcentaje > porcentajeMaximo){
                porcentajeMaximo = porcentaje;
                grupo = x + 1;
                }

            
            }

            Console.WriteLine("El grupo con el mayor porcentaje es " + grupo);


        }
    }
}
