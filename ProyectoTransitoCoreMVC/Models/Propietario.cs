using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoTransitoCoreMVC.Models
{
    public partial class Propietario
    {
        public Propietario()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public string Dnipro { get; set; }
        public string Nompro { get; set; }
        public string Dirpro { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
