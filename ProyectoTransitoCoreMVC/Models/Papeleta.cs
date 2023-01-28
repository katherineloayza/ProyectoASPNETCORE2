using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoTransitoCoreMVC.Models
{
    public partial class Papeleta
    {
        public int Nropap { get; set; }
        public string Nropla { get; set; }
        public string Codinf { get; set; }
        public string Codpol { get; set; }
        public DateTime? Fechapap { get; set; }
        public string Pagado { get; set; }
        public DateTime? Fechapago { get; set; }
        public string Eliminado { get; set; }

        public virtual Infraccione CodinfNavigation { get; set; }
        public virtual Policia CodpolNavigation { get; set; }
        public virtual Vehiculo NroplaNavigation { get; set; }
    }
}
