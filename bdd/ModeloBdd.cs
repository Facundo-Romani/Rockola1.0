using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace bdd
{
    // CONEXIÓN A BASE DE DATOS CREANDO MÉTODOS Y CONSTRUCTOR.
    public class ModeloBdd
    {
        private SqlConnection conexion; 
        private SqlCommand comando;
        private SqlDataReader lectura1;

        public SqlDataReader Lectura1 
        {
            get { return lectura1; }
        }

        public ModeloBdd()
        {
            conexion = new SqlConnection("server =.\\SQLEXPRESS; database = DISCOS_DB; integrated security = true;");
            comando = new SqlCommand(); 
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarConsulta()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lectura1 = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lectura1 != null)
                lectura1.Close();
            conexion.Close();
        }
    }
}
