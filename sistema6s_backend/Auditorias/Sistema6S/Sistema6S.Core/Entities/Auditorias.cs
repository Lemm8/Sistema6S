using System;
using System.Collections.Generic;

namespace Sistema6S.Core.Entities
{
    public partial class Auditorias
    {
        public string Nombre { get; set; }
        public int AuditorId { get; set; }
        public int? AreaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaTarget { get; set; }
        public DateTime? FechaCompleto { get; set; }
        public int Estado { get; set; }
        public int? CalificacionId { get; set; }
        public int AuditoriaId { get; set; }

        public Areas Area { get; set; }
        public Auditores Auditor { get; set; }
        public Calificaciones Calificacion { get; set; }
    }
}
