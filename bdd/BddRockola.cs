using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace bdd
{

    // CONEXIÓN A BASE DE DATOS DENTRO DE LA MISMA CLASE.
    public class BddRockola
    {
        public List<Rockola> lista()
        {
            // Conexión a BDD.
            List<Rockola> listaMusica = new List<Rockola>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server =.\\SQLEXPRESS; database = DISCOS_DB; integrated security = true; ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa from DISCOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                // Mapeo.
                while (lector.Read())
                {
                    Rockola cargaDeMusica = new Rockola();
                    cargaDeMusica.Titulo = (string)lector["Titulo"];
                    cargaDeMusica.Fecha = lector.GetDateTime(1);
                    cargaDeMusica.Canciones = lector.GetInt32(2);
                    cargaDeMusica.Url = (string)lector["UrlImagenTapa"];

                    listaMusica.Add(cargaDeMusica);
                }

                conexion.Close();
                return listaMusica;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}
