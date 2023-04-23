using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //herencia se lee como "ES"

            //Auto a5 = new Auto();
            //a5.Motor = new Motor();

            Vehiculo v1 = new Vehiculo();   
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            c1.Color = "amarillo";
            c2.Color = "rojo";
            c3.Color = "blanco";
  
            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);


            Console.WriteLine("La cantidad de camionetas es " + listaCamionetas.Count);
            listaCamionetas[1].Color = "negra";
            c2.Color = "verde";
            Console.WriteLine("El color de la camionetas es " + listaCamionetas[1].Color);
            listaCamionetas.Remove(c1);
            Console.WriteLine("La cantidad de camionetas es " + listaCamionetas.Count);

            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color " + item.Color);

            }
            Console.ReadKey();



        }
    }
}
