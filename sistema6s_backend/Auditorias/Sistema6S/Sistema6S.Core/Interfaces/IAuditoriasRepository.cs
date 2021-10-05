using Sistema6S.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema6S.Core.Interfaces
{
    public interface IAuditoriasRepository
    {
        Task<IEnumerable<Auditorias>> GetAuditorias();
    }
}
