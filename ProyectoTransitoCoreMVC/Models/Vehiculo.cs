using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoTransitoCoreMVC.Models
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Papeleta = new HashSet<Papeleta>();
        }

        public string Nropla { get; set; }
        public string Dnipro { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
        public int? Año { get; set; }
        public string Eliminado { get; set; }

        public virtual Propietario DniproNavigation { get; set; }
        public virtual ICollection<Papeleta> Papeleta { get; set; }
    }
}
