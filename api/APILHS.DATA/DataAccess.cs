using System.Data;
using System.Data.SqlClient;
using APILHS.MODELS;
namespace APILHS.DATA
{
    public class DataAccess
    {
        public readonly string connectionString = $"Server=localhost;Database=TuBaseDeDatos;User=TuUsuario;Password=TuContraseña;";

        public static string Get()
        {
           
            string connection = string.Format("Server={0};Database={1};User={2};Password={3};",
            "LAPTOP-9T93LIFD\\SERVIDORSQL", "BD_HOSPITALES", "weduardo", "sysadmin");

            return connection;
        }

    }
}
