using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        private string modelo;
        private string marca;
        private int numeroTelefonico;
        private int codigoOperador;
        private string contacto;

        public Telefono(string modelo, string marca) 
        {
            this.modelo = modelo;
            this.marca = marca;

        }
        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }
        }

        public int NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodOperador 
        {
            get {return codigoOperador;}
            set 
            {
                if (value > 0 && value < 4) 
                {
                    codigoOperador = value;
                }else{
                    codigoOperador = 0;
                }
                

            }
        
        } 
        
        public string Llamar() 
        {
            return ("Realizando llamada...");
        }

        public string Llamar(string contacto) 
        {
            return ("Realizando llamada a " + contacto); 
        }
    }
}
