using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILHS.MODELS
{

    public class Diagnostic
    {
        public partial class RequestDiagnostic
        {
            public List<Backend>? DiagnosticList { get; set; }
        }

        public partial class Backend
        {
            public decimal? CodAtencion { get; set; }
            public int? IdPaciente { get; set; }
            public string? CodEss { get; set; }
            public string? CodUbigeo { get; set; }
            public string? CodSexo { get; set; }
            public DateTime? FechaNacimiento { get; set; }
            public decimal? Edad { get; set; }
            public DateTime? FechaAtencion { get; set; }
            public DateTime? FechaHospitalizacion { get; set; }
            public DateTime? FechaAlta { get; set; }
            public string? CodServicio { get; set; }
            public string? CodGrupoEtereo { get; set; }
            public string? PeridoRegistro { get; set; }
            public string? MesRegistro { get; set; }
            public string? TipoDocumento { get; set; }
            public decimal? ValorServicio { get; set; }
            public decimal? ValorProcedimiento { get; set; }
            public decimal? ValorMedicamento { get; set; }
            public decimal? ValorInsumo { get; set; }
            public decimal? ValorTotal { get; set; }
        }

    }

    
}
