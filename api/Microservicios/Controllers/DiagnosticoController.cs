using APILHS.MODELS;
using Microsoft.AspNetCore.Mvc;
using System.Net;
namespace Microservicios.Controllers
{
    [Route("lhs/Diagnostic")]
    public class DiagnosticoController : ControllerBase
    {

        [HttpPost]
        [HttpPut]
        [Route("PerCase")]
        public dynamic PostPerCase([FromBody] Diagnostic.RequestDiagnostic DiagnosticList)
        {
            try
            {
                var PostRecordDiagnostic = APILHS.DATA.Diagnostico.Diagnostico.PostRecordCasePerCase(DiagnosticList);

                return new { PostRecordDiagnostic };

            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}
