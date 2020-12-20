using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.clases
{
    public class TipoHabitacion
    {
        public TipoHabitacion(){ }
        public virtual int Id { get; set; }
        public virtual string Tipo { get; set; }
        public virtual float Precio { get; set; }
        public virtual IList<Habitacion> Habitacions { get; set; }
    }
}