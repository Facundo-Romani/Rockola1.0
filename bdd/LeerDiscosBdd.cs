using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace bdd
{
    public class LeerDiscosBdd
    {
        List<Rockola> lista()
        {
            List<Rockola> listar = new List<Rockola>();
            ModeloBdd datos = new ModeloBdd();
            
            try
            {
                datos.setearConsulta("select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa from DISCOS");
                datos.ejecutarConsulta();

                while (datos.Lectura1.Read())
                {
                    Rockola aux = new Rockola();
                    aux.Titulo = (string)datos.Lectura1["Titulo"];
                    aux.Fecha = (DateTime)datos.Lectura1["Fecha"];
                    aux.Canciones = (int)datos.Lectura1["CantidadCanciones"];
                    aux.Url = (string)datos.Lectura1["url"];

                    listar.Add(aux);
                }
                return listar;
            }
          
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion(); 
            }
            
        }
    }
}
