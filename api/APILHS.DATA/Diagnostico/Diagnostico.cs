using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILHS.DATA.Diagnostico
{
    public class Diagnostico
    {

        public static dynamic PostRecordCasePerCase(List<APILHS.MODELS.Diagnostico>? lDiagnostico)
        {
            DataTable dtDiagnostico;
            try
            {

                dtDiagnostico = APILHS.DATA.Function.General.ListToDataTable(lDiagnostico);

                using SqlConnection connection = new SqlConnection(DataAccess.Get());
                
                SqlCommand command = new SqlCommand("sp",connection);
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                
                SqlParameter dtParameter = new SqlParameter("@Param", SqlDbType.Structured);
                dtParameter.Value = lDiagnostico;
                command.Parameters.Add(dtParameter);



            }
            catch (Exception ex) { }

            return new { };
        }

    }
}
