using APILHS.MODELS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace APILHS.DATA
{
    public class DataAccess
    {
        private readonly string connectionString;

        public DataAccess()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "",
                UserID = "",
                Password = "",
            };

            connectionString = builder.ConnectionString;
        }

        public IDataReader InsertDiagnotico(Diagnostico diag)
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
