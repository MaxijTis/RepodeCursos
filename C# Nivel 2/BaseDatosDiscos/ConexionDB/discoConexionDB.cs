using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clasesDominio;
using System.Data.SqlClient;

namespace ConexionDB
{
    public class discoConexionDB
    {
        public List <Discos> listar() 
        { 
            List<Discos> lista = new List<Discos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try 
            {
                conexion.ConnectionString = "server=DESKTOP-F9RSI6B\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Titulo, FechaLanzamiento, CantidadCanciones from DISCOS";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();
                while (lector.Read())
                { 
                    Discos aux = new Discos();
                    aux.Titulo = (String)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
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
