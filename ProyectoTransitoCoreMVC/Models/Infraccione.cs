using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoTransitoCoreMVC.Models
{
    public partial class Infraccione
    {
        public Infraccione()
        {
            Papeleta = new HashSet<Papeleta>();
        }

        public string Codinf { get; set; }
        public string Descrip { get; set; }
        public int Grado { get; set; }
        public decimal Importe { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Papeleta> Papeleta { get; set; }
    }
}
