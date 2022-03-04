using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace bdd
{
    public class ElementoDiscos
    {
        public List<Rockola> listar()
        {
            List<Rockola> lista = new List<Rockola>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearDatos("select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa from DISCOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Rockola aux = new Rockola();

                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Fecha = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.Canciones = (int)datos.Lector["CantidadCanciones"];
                    aux.Url = (string)datos.Lector["url"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }
    }
}
