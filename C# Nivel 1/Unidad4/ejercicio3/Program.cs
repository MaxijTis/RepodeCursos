using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            //	          i5 (1)	i7 (2)	i9 (3)
            //8 RAM (1)	USD 800	USD 900	 USD 1200
            //16 RAM (2)USD 900	USD 1000 USD 1400
            //32 RAM (3)USD 1000 USD 1400 USD 2000
            //Además, el equipo viene con un disco que permite almacenar 500 GB de información
            // y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional 
            //de USD 300. Hacer un programa que solicite la opción de procesador, la opción de 
            //memoria  RAM, y si extiende el disco o no (ingresa 1 para extender 
            //y 0 para no extender) y calcule y emita por pantalla el monto de la máquina 
            //seleccionada.
            
            int procesador , memoria, disco; 
            int monto = 0;

            Console.WriteLine("Ingrese la opcion para procesador: ");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la opcion de memoria ram: ");
            memoria = int.Parse(Console.ReadLine());

           if(procesador == 1 && memoria == 1){
               monto = 800;
               Console.WriteLine("Su precio es  USD 800 ");
           }
            if(procesador == 1 && memoria == 2){
               monto = 900;
               Console.WriteLine("Su precio es  USD 900 ");
           }
           if(procesador == 1 && memoria == 3){
               monto = 1000;
               Console.WriteLine("Su precio es  USD 1000 ");
           }


            if(procesador == 2 && memoria == 1){
               monto = 900;
               Console.WriteLine("Su precio es  USD 900 ");
           }
           if(procesador == 2 && memoria == 2){
               monto = 1000;
               Console.WriteLine("Su precio es  USD 1000 ");
           }
           if(procesador == 2 && memoria == 3){
               monto = 1400;
               Console.WriteLine("Su precio es  USD 1400 ");
           }

           if(procesador == 3 && memoria == 1){
               monto = 1000;
               Console.WriteLine("Su precio es  USD 1000 ");
           }
           if(procesador == 3 && memoria == 2){
               monto = 1400;
               Console.WriteLine("Su precio es  USD 1400 ");
           }
           if(procesador == 3 && memoria == 3){
               monto = 2000;
               Console.WriteLine("Su precio es  USD 2000 ");
           }

           Console.WriteLine("¿Desea ampliar la memoria del disco duro?");
           memoria = int.Parse(Console.ReadLine());

         if(memoria == 1){
             disco = monto + 300;
             Console.WriteLine("su importe a pagar es " + disco);
         }else{
             Console.WriteLine("su importe a pagar es " + monto);
         }
               
           
            

            
        }
    }
}
