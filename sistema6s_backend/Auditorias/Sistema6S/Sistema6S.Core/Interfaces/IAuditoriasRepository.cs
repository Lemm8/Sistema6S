using Sistema6S.Core.DTOs;
using Sistema6S.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema6S.Core.Interfaces
{
    public interface IAuditoriasRepository
    {
        Task<IEnumerable<Auditorias6s>> GetAuditorias();
        Task<Auditorias6s> GetAuditoria(int id);
        Task PostAuditoria(Auditorias6s auditoria);

        Task<IEnumerable<Auditores6s>> GetAuditores();
        Task<Auditores6s> GetAuditor(int id);

        Task<IEnumerable<Areas6s>> GetAreas();
        Task<Areas6s> GetArea(int id);
    }
}
