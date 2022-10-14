using System;
using System.Collections.Generic;

namespace MvcCrud.Models
{
    public partial class NotasEst
    {
        public int IdNotasE { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public short? Ipn { get; set; }
        public short? Iipn { get; set; }
        public short? Siste { get; set; }
        public short? Proyect { get; set; }
        public short? Nf { get; set; }
        public short? Exci { get; set; }
        public short? Nfci { get; set; }
        public short? Excii { get; set; }
        public short? Nfcii { get; set; }
    }
}
