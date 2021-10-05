using System;
using System.Collections.Generic;

namespace Sistema6S.Core.Entities
{
    public partial class Areas
    {
        public Areas()
        {
            Auditorias = new HashSet<Auditorias>();
            Departamentos = new HashSet<Departamentos>();
        }

        public int AreaId { get; set; }
        public string Nombre { get; set; }
        public int? AuditoriaId { get; set; }

        public ICollection<Auditorias> Auditorias { get; set; }
        public ICollection<Departamentos> Departamentos { get; set; }
    }
}
