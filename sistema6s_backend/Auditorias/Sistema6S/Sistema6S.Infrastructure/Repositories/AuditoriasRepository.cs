using Microsoft.EntityFrameworkCore;
using Sistema6S.Core.Entities;
using Sistema6S.Core.Interfaces;
using Sistema6S.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistema6S.Infrastructure.Repositories
{
    public class AuditoriasRepository : IAuditoriasRepository
    {
        // INYECCIÓN DE DEPENDENCIA DEL CONTEXTO DE BD
        private readonly Sistema6SContext _dbcontext;
        public AuditoriasRepository(Sistema6SContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        public async Task<IEnumerable<Auditorias>> GetAuditorias()
        {
            // CONEXIÓN CON BD Y RETORNAR LISTA ASÍNCRONA
            var auditorias = await _dbcontext.Auditorias.ToListAsync();
            return auditorias;
        }
    }
}
