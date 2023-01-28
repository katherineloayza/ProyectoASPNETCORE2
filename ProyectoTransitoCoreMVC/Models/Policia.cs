using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoTransitoCoreMVC.Models
{
    public partial class Policia
    {
        public Policia()
        {
            Papeleta = new HashSet<Papeleta>();
        }

        public string Codpol { get; set; }
        public string Nompol { get; set; }
        public string Dirpol { get; set; }
        public string Patrullero { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Papeleta> Papeleta { get; set; }
    }
}
