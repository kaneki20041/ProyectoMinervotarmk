using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=35.184.250.185; Initial Catalog=Minerva; User ID=sqlserver; Password=1234; Integrated Security=false";

            return cn;
        }
    }
}   