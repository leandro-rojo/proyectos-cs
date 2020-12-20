using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.clases
{
    public class Alojamiento
    {
        public Alojamiento()
        {
        }
        public virtual int Id { get; set; }
        public virtual DateTime FechaEntrada { get; set; }
        public virtual DateTime FechaSalida { get; set; }
        public virtual float ImporteServicios { get; set; }
        public virtual float ImporteHabitacion { get; set; }
        public virtual Habitacion Habitacion_ { get; set; }
        public virtual Huesped Huesped_ { get; set; }
    }
}