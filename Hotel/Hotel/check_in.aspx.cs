using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernate;
using System.Collections;
using Hotel.clases;

namespace Hotel
{
    public partial class check_in : System.Web.UI.Page
    {
        ISessionFactory sesiones;
        ISession sesion;
        ICriteria sc;
        IList tipos;
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem li;
            sesiones = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            sesion = sesiones.OpenSession();
            if (!IsPostBack)
            {
                sc = sesion.CreateCriteria(typeof(TipoHabitacion));
                tipos = sc.List();
                //Carga el listbox de cursos
                foreach (TipoHabitacion t in tipos)
                {
                    li = new ListItem(t.Tipo + "$" + t.Precio, t.Id.ToString());
                    Ddl1.Items.Add(li);
                }
            }
            
        }

        protected void Ddl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<Habitacion> habitaciones;
            int hab_sel = int.Parse(Ddl1.SelectedValue);
            TipoHabitacion t = sesion.Get<TipoHabitacion>(hab_sel);
            if(t!=null)
            {
                habitaciones = t.Habitacions;
                ListItem li;
                RBLst.Items.Clear();
                //sesiones = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                //sesion = sesiones.OpenSession();
                foreach (Habitacion h in habitaciones)
                {
                    if (h.Estado == "disponible")
                    {
                        sc = sesion.CreateCriteria(typeof(Habitacion));
                        tipos = sc.List();
                        li = new ListItem(h.Numero.ToString(), h.Id.ToString());
                        RBLst.Items.Add(li);
                    }
                }
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IList Huespedes;
            //sesiones = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            //sesion = sesiones.OpenSession();
            sc = sesion.CreateCriteria(typeof(Huesped));
            Huespedes = sc.List();
            int i = -1;
            foreach (Huesped hu in Huespedes)
            {
                if (TxtBox_1.Text == hu.Dni)
                {
                    i = hu.Id;
                }
            }
            if(i!=-1)
            {
                Alojamiento al = new Alojamiento();
                al.FechaEntrada = Calendar1.SelectedDate;
                al.FechaSalida = Calendar2.SelectedDate;
                al.ImporteHabitacion = 0;
                al.ImporteServicios = 0;
                Huesped hues = sesion.Get<Huesped>(i);
                //Label5.Text = hues.Nombre;
                al.Huesped_ = hues;
                Habitacion hab = sesion.Get<Habitacion>(int.Parse(RBLst.SelectedValue));
                hab.Estado = "ocupado";
                al.Habitacion_ = hab;
                sesion.SaveOrUpdate(hab);
                sesion.Save(al);
                sesion.Flush();
                Label5.Text = "Huesped registrado";

            }
            else
            {
                Label5.Text = "Huesped no registrado";
                HyperLink1.Visible = true;
            }
            sesion.Close();
            sesiones.Close();
        }
    }
}