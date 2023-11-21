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
            "localhost", "LHS", "WEduardo", "12345678");

            return connection;
        }

        public IDataReader InsertDiagnotico(APILHS.MODELS.Diagnostico diag)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string storedProcedureName = "Sp";
                SqlCommand command = new SqlCommand(storedProcedureName, connection);

                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Param", diag.Id);
                return command.ExecuteReader();
            }
        }
    }
}
