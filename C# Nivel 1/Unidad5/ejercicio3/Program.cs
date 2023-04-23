using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el 
            //promedio de edad de aquellas personas mayores a 18 años.

            int edad = 0, acu = 0, contador = 0, promedio = 0;


            for (int X = 0; X < 20; X++){
                
                 Console.WriteLine("Ingresa una edad.. ");
                 edad = int.Parse(Console.ReadLine());
            
                if(edad > 18){
                    contador++;
                    acu += edad;
               }
            }

            promedio = acu / contador;
           
            Console.WriteLine("El promedio de edad es " + promedio);

        }
    }
}
