using Microsoft.AspNetCore.Mvc;
using Sistema6S.Core.Interfaces;
using Sistema6S.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema6S.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditoriasController : ControllerBase
    {
        private readonly IAuditoriasRepository _repository;
        public AuditoriasController(IAuditoriasRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuditorias()
        {
            var auditorias = await _repository.GetAuditorias();
            return Ok(auditorias);                        
        }
    }
}
