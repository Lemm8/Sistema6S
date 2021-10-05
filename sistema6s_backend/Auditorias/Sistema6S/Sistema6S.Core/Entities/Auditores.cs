using System;
using System.Collections.Generic;

namespace Sistema6S.Core.Entities
{
    public partial class Auditores
    {
        public Auditores()
        {
            Auditorias = new HashSet<Auditorias>();
        }

        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int UserId { get; set; }

        public ICollection<Auditorias> Auditorias { get; set; }
    }
}
