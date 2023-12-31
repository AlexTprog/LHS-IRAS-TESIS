﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace APILHS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiagnosticoController
    {
        private readonly ILogger<Diagnostico> _logger;

        public DiagnosticoController(ILogger<Diagnostico> logger)
        {
            _logger = logger;
        }

        
        [HttpPost]
        public IActionResult Get()
        {
            var data = new DataAccess();
            var diag = data.InsertDiagnotico(new Diagnostico { Id = 1 });

            return new JsonResult(diag);
           
        }
        
    }
}
