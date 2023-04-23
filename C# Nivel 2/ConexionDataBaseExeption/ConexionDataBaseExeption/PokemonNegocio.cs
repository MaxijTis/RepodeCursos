using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //hay que incluir esta libreria

namespace ConexionDataBaseExeption
{
    class PokemonNegocio
    {
        public List<Pokemon> listar() 
        {
            //lo siguiente Para establecer la conexion y leer los datos(hay que
            //declarar unos objetos y declararlos)
            //
            SqlConnection conexion = new SqlConnection();//para conectarme a algun lado
            SqlCommand comando = new SqlCommand();//para poder hacer acciones una vez conectado
            SqlDataReader lector;//el resultado de la lectura se guarda en esa variable
            List<Pokemon> lista = new List<Pokemon>();
            try
            {
                conexion.ConnectionString = "Server=.\\SQLEXPRESS; database=POKEDEX_DB;integrated security=true; " ;
                //con esto configuramos la cadena de conexion que es un atributo de la conexion
                //el server se puede poner el que aparece al principio en SQL
                //siguiente a que base de dato se va a conectarO ACCEDER
                //lo ultimo es como me voy a conectar,
                comando.CommandType = System.Data.CommandType.Text;
                //comando realiza la accion en este caso hacemos una lectura
                //commandtype es un tipo de comando
                comando.CommandText = "select Numero, Nombre, Descripcion from Pokemons";
                comando.Connection = conexion;//el comando anterioir que lo ejecute en esa "Conexion"  

                conexion.Open();
                lector = comando.ExecuteReader();//se realiza la lectura

                while (lector.Read())//si hay un registro devuelve true y
                                     //entra al while y deja un puntero en la siguiente posicion
                {
                    Pokemon aux = new Pokemon();//y lo voy a cargar con los datos de ese registro
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
