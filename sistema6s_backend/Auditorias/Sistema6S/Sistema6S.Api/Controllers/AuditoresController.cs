using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema6S.Core.Interfaces;

namespace Sistema6S.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditoresController : Controller
    {
        
        private readonly IAuditoresRepository _repository;
        public AuditoresController(IAuditoresRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuditores()
        {
            var auditorias = await _repository.GetAuditores();
            return Ok(auditorias);                        
        }
    }
}