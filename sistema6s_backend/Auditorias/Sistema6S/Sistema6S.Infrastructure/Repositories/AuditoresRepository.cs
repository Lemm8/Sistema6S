using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema6S.Core.Entities;
using Sistema6S.Core.Interfaces;
using Sistema6S.Infrastructure.Data;

namespace Sistema6S.Infrastructure.Repositories
{
    public class AuditoresRepository: IAuditoresRepository
    {
        
        private readonly Sistema6SContext _dbcontext;
        public AuditoresRepository(Sistema6SContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        public async Task<IEnumerable<Auditores>> GetAuditores()
        {
            // CONEXIÓN CON BD Y RETORNAR LISTA ASÍNCRONA
            var auditores = await _dbcontext.auditores_6s.ToListAsync();
            return auditores;
        }
    }
}