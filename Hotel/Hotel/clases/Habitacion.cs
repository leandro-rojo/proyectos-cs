using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.clases
{
    public class Habitacion
    {
        public Habitacion()
        {
        }
        public virtual int Id { get; set; }
        public virtual string Estado { get; set; }
        public virtual int Numero { get; set; }
        public virtual int Piso { get; set; }
        public virtual TipoHabitacion TipoDeHabitacion { get; set; }
        public virtual IList<Alojamiento> Alojamientos { get; set; }
    }
}