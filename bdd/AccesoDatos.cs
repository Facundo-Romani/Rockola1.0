//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;


//namespace bdd
//{
//    public class AccesoDatos
//    {
//        // Atributos de Objetos  para la conexion.
//        private SqlConnection conexion;
//        private SqlCommand comando;
//        private SqlDataReader lector;
//        // Metodo de lectura publico para poder acceder desde el exterior.
//        public SqlDataReader Lector
//        {
//            get { return lector; }
//        }

//        // Crear constructor para dar estado inicial al objeto conexion.
//        public AccesoDatos()
//        {
//            conexion = new SqlConnection("server =.\\SQLEXPRESS; database = DISCOS_DB; integrated security = true;");
//            comando = new SqlCommand();
//        }

//        // Metodo para setear conexion.
//        public void setearDatos(string consulta)
//        {
//            comando.CommandType = System.Data.CommandType.Text;
//            comando.CommandText = consulta;
//        }

//        // Metodo para Abrir conexion.
//        public void ejecutarLectura()
//        {
//            comando.Connection = conexion;
//            try
//            {
//               conexion.Open();
//               lector = comando.ExecuteReader();
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }
//        }

//        // Metodo Cerrar conexion.
//        public void cerrarConexion()
//        {
//            if(lector != null)
//                lector.Close();
//            conexion.Close();
//        }
//    }
//}
