using Microsoft.EntityFrameworkCore;
using Sistema6S.Core.DTOs;
using Sistema6S.Core.Entities;
using Sistema6S.Core.Interfaces;
using Sistema6S.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

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


        public async Task<IEnumerable<Auditorias6s>> GetAuditorias()
        {
            // CONEXIÓN CON BD Y RETORNAR LISTA ASÍNCRONA
            var auditorias = await _dbcontext.Auditorias6s.ToListAsync();
            //var a = _dbcontext.Auditorias6s.FromSql(
            //    "SELECT ads. from"   
            //).ToListAsync();
            return auditorias;
        }

        public async Task<Auditorias6s> GetAuditoria(int id)
        {
            var auditoria = await _dbcontext.Auditorias6s.FirstOrDefaultAsync(x => x.AuditoriaId == id);

            //var auditoria = await _dbcontext.Auditorias6s.
            //    Select
            return auditoria;
        }

        public async Task PostAuditoria(Auditorias6s auditoria)
        {
            _dbcontext.Auditorias6s.Add(auditoria);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Auditores6s>> GetAuditores()
        {
            var auditores = await _dbcontext.Auditores6s.ToListAsync();
            return auditores;
        }

        public async Task<Auditores6s> GetAuditor(int id)
        {
            var auditor = await _dbcontext.Auditores6s.FirstOrDefaultAsync(x => x.UserId == id);
            return auditor;
        }

        public async Task<IEnumerable<Areas6s>> GetAreas()
        {
            var areas = await _dbcontext.Areas6s.ToListAsync();
            return areas;
        }

        public async Task<Areas6s> GetArea(int id)
        {
            var area = await _dbcontext.Areas6s.FirstOrDefaultAsync(x => x.AreaId == id);
            return area;
        }
    }
}
