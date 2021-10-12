using System.Collections.Generic;
using System.Threading.Tasks;
using Sistema6S.Core.Entities;

namespace Sistema6S.Core.Interfaces
{
    public interface IAuditoresRepository
    {
        Task<IEnumerable<Auditores>> GetAuditores();
    }
}