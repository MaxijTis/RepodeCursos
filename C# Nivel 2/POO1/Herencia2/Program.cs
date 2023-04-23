using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //AnimalDomestico a1 = new AnimalDomestico();
            //a1.nombre = "PEPE";
            //Console.WriteLine(a1.ToString());
            
            Gato g1 = new Gato();
            g1.nombre = "Amiguero";

            Perro p1 = new Perro();
            p1.nombre = "Negrito";

            Animal a1 = g1;
            Gato g8 = (Gato)a1;
            g8.nombre = "Blanquito";


            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(g1);
            animales.Add(new Aguila());
            animales.Add(new Gato());

            List<flyable> listaVoladores = new List<flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());

            
            
            Console.WriteLine(p1.Comunicarse());
            Console.WriteLine(g1.Comunicarse());

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.Comunicarse());

            }

            //polimorfismo: es la distinta respuesta que genera un objeto a un mismo estimulo
            Console.ReadKey();
        }
    }
}
