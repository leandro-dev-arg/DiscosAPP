using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DiscosAPP
{
    internal class DiscosNegocio
    {
        public List<Discos> listar() 
        {
            List<Discos> lista=new List<Discos> ();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            

            try
            {
                conexion.ConnectionString = "server =.\\SQLEXPRESS; database=DISCOS_DB; integrated security = true;";
                comando.CommandType =System.Data.CommandType.Text;
                comando.CommandText = "select D.Titulo,D.FechaLanzamiento as Lanzamiento,D.UrlImagenTapa,D.CantidadCanciones as Canciones,E.Descripcion as Estilo from DISCOS D,ESTILOS E,TIPOSEDICION TE where E.Id=D.IdEstilo";
                comando.Connection = conexion;
                conexion.Open();
                lector=comando.ExecuteReader();


                while (lector.Read())
                {
                    Discos aux = new Discos();

                    aux.Titulo = (string)lector["Titulo"];
                    aux.Lanzamiento = (DateTime)lector["Lanzamiento"];
                    aux.Canciones = (int)lector["Canciones"];
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];
                    aux.Genero = new Genero();
                    aux.Genero.Descripcion = (string)lector["Estilo"];

;                    lista.Add(aux);

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
