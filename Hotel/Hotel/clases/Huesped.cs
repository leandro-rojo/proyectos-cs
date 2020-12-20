using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.clases
{
    public class Huesped
    {
        public Huesped()
        {
        }
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string NumeroTarjeta { get; set; }
        public virtual string Dni { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string Telefono { get; set; }
        public virtual IList<Alojamiento> Alojamientos { get; set; }
    }

}