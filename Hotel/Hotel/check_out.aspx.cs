using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using NHibernate;
using Hotel.clases;

namespace Hotel
{
    public partial class check_out : System.Web.UI.Page
    {
        ISessionFactory sesiones;
        ISession sesion;
        ICriteria sc;
        IList lista;
        static float b = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            float a = 0;
            TimeSpan cant_noches;
            sesiones = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            sesion = sesiones.OpenSession();
            Habitacion hab = sesion.Get<Habitacion>(int.Parse(DropDownList2.SelectedValue));
            if (hab.Estado == "ocupado")
            {
                Label3.Visible = true;
                IList<Alojamiento> alo = hab.Alojamientos;
                int aux = alo[alo.Count - 1].Id;
                Alojamiento al = sesion.Get<Alojamiento>(aux);
                if (al.FechaSalida.ToShortDateString() == DateTime.Today.ToShortDateString())
                    Label3.Text = "La fecha de salida coincide ";
                else
                {
                    al.FechaSalida = DateTime.Today;
                    Label3.Text = "La fecha de salida se actualizo";
                }
                cant_noches = al.FechaSalida.Date - al.FechaEntrada.Date;
                a = cant_noches.Days * hab.TipoDeHabitacion.Precio + al.ImporteServicios;
                Label4.Text = "Monto: " + a;
                b = cant_noches.Days * hab.TipoDeHabitacion.Precio;
                Button1.Visible = true;
            }
            else
            {
                Button1.Visible = false;
                Label3.Visible = false;
                Label4.Text = "Habitacion Desocupada";
            }




            sesion.Close();
            sesiones.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sesiones = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            sesion = sesiones.OpenSession();
            Habitacion hab = sesion.Get<Habitacion>(int.Parse(DropDownList2.SelectedValue));
            IList<Alojamiento> alo = hab.Alojamientos;
            int aux = alo[alo.Count - 1].Id;
            Alojamiento al = sesion.Get<Alojamiento>(aux);
            al.ImporteHabitacion = b;
            Label4.Text = al.ImporteHabitacion.ToString();
            hab.Estado = "disponible";
            sesion.SaveOrUpdate(al);
            sesion.SaveOrUpdate(hab);
            sesion.Flush();
            sesion.Close();
            sesiones.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            ListItem li;
            sesiones = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            sesion = sesiones.OpenSession();
            sc = sesion.CreateCriteria(typeof(Habitacion));
            lista = sc.List();

            foreach (Habitacion h in lista)
            {
                if (h.Piso == int.Parse(DropDownList1.SelectedValue))
                {
                    li = new ListItem(h.Numero.ToString(), h.Id.ToString());
                    DropDownList2.Items.Add(li);
                }
            }
        }
    }
}