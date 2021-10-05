using System;
using System.Collections.Generic;

namespace Sistema6S.Core.Entities
{
    public partial class Calificaciones
    {
        public Calificaciones()
        {
            Auditorias = new HashSet<Auditorias>();
        }

        public double S1 { get; set; }
        public double S2 { get; set; }
        public double S3 { get; set; }
        public double S4 { get; set; }
        public double S5 { get; set; }
        public double S6 { get; set; }
        public int CalificacionId { get; set; }

        public ICollection<Auditorias> Auditorias { get; set; }
    }
}
