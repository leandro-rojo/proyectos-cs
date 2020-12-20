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
    public partial class ServicioHabitacion : System.Web.UI.Page
    {
        ISessionFactory sesiones;
        ISession sesion;
        ICriteria sc,sc1;
        IList lista;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownList3.Items.Clear();
            ListItem li;
            sesiones = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            sesion = sesiones.OpenSession();
            sc = sesion.CreateCriteria(typeof(Habitacion));
            lista = sc.List();

            foreach (Habitacion h in lista)
            {
                if (h.Piso == int.Parse(DropDownList2.SelectedValue))
                {
                    li = new ListItem(h.Numero.ToString(), h.Id.ToString());
                    DropDownList3.Items.Add(li);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float a = 0;
            try
            {
                a=float.Parse(TextBox1.Text);
               
            }
            catch(Exception ex)
            {
                Label5.Text = ex.Message;
                Label5.ForeColor = System.Drawing.Color.BlueViolet;
            }
            sesiones = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            sesion = sesiones.OpenSession();
            Habitacion hab=sesion.Get<Habitacion>(int.Parse(DropDownList3.SelectedValue));
            IList<Alojamiento> alo = hab.Alojamientos;
            int aux=alo[alo.Count-1].Id;
            Alojamiento al = sesion.Get<Alojamiento>(aux);
            al.ImporteServicios += a;
            Label5.Text = "importe por servicios adicionales $" + al.ImporteServicios;
            sesion.SaveOrUpdate(al);
            sesion.Flush();
            sesion.Close();
            sesiones.Close();
        }
    }
}