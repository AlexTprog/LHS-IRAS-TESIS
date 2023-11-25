using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APILHS.MODELS;
using Dapper;

namespace APILHS.DATA.Diagnostico
{
    public class Diagnostico
    {

        public static dynamic PostRecordCasePerCase(Diagnostic.RequestDiagnostic? lDiagnostico)
        {
            DataTable dtDiagnostico;
            try
            {

                dtDiagnostico = APILHS.DATA.Function.General.ListToDataTable(lDiagnostico.DiagnosticList);

                using SqlConnection connection = new SqlConnection(DataAccess.Get());

                connection.Open();

                var parameter = new
                {
                    Regist = dtDiagnostico.AsTableValuedParameter("dbo.MassiveRegist")
                };

                foreach (var item in lDiagnostico.DiagnosticList)
                {
                    var props = item.GetType().GetProperties();
                    foreach (var prop in props)
                    {
                        Console.WriteLine($"{prop.Name}: {prop.PropertyType}");
                    }
                }

                dynamic diagnostic = connection.Query("LHS_DiagnosticByMassive",parameter, commandType: CommandType.StoredProcedure).ToList();

                return diagnostic;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return new { };
        }

    }
}
