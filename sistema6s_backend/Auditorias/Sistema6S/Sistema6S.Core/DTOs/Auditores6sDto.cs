using Sistema6S.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema6S.Core.DTOs
{
    public class Auditores6sDto
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int UserId { get; set; }

        public ICollection<Auditorias6s> Auditorias6s { get; set; }
    }
}
