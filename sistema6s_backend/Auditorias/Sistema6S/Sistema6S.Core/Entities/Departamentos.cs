using System;
using System.Collections.Generic;

namespace Sistema6S.Core.Entities
{
    public partial class Departamentos
    {
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public int? Aforo { get; set; }
        public int AreaId { get; set; }

        public Areas Area { get; set; }
    }
}
