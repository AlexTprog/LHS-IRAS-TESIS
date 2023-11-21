using Microsoft.AspNetCore.Mvc;
using System.Net;
namespace Microservicios.Controllers
{
    [Route("lhs/Diagnostic")]
    public class DiagnosticoController : ControllerBase
    {

        [HttpPost]
        [Route("PerCase")]
        public dynamic PostPerCase([FromBody] List<APILHS.MODELS.Diagnostico>? lDiagnostic)
        {
            try
            {
                var PostRecordDiagnostic = APILHS.DATA.Diagnostico.Diagnostico.PostRecordCasePerCase(lDiagnostic);

                return new { PostRecordDiagnostic };
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}
