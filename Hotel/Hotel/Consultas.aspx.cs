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
    public partial class Consultas : System.Web.UI.Page
    {
        ISessionFactory sesiones;
        ISession sesion;
        ICriteria sc;
        IList lista;
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sesiones = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            sesion = sesiones.OpenSession();
            Habitacion hab = sesion.Get<Habitacion>(int.Parse(DropDownList2.SelectedValue));
            if (hab.Estado == "ocupado")
            {
                IList<Alojamiento> alo = hab.Alojamientos;
                if (alo.Count != 0)
                {
                    int aux = alo[alo.Count - 1].Id;
                    Alojamiento al = sesion.Get<Alojamiento>(aux);
                    TableRow fila;
                    TableCell celda;
                    fila = new TableRow();
                    celda = new TableCell();
                    celda.Text = "Fecha De Entrada: ";
                    fila.Cells.Add(celda);
                    celda = new TableCell();
                    celda.Text = al.FechaEntrada.ToShortDateString();
                    fila.Cells.Add(celda);
                    Table1.Rows.Add(fila);

                    fila = new TableRow();
                    celda = new TableCell();
                    celda.Text = "Fecha De Salida: ";
                    fila.Cells.Add(celda);
                    celda = new TableCell();
                    celda.Text = al.FechaSalida.ToShortDateString();
                    fila.Cells.Add(celda);
                    Table1.Rows.Add(fila);

                    fila = new TableRow();
                    celda = new TableCell();
                    celda.Text = "Importe Adicional: ";
                    fila.Cells.Add(celda);
                    celda = new TableCell();
                    celda.Text = al.ImporteServicios.ToString();
                    fila.Cells.Add(celda);
                    Table1.Rows.Add(fila);

                    fila = new TableRow();
                    celda = new TableCell();
                    celda.Text = "Huesped: ";
                    fila.Cells.Add(celda);
                    celda = new TableCell();
                    celda.Text = al.Huesped_.Nombre;
                    fila.Cells.Add(celda);
                    Table1.Rows.Add(fila);

                    fila = new TableRow();
                    celda = new TableCell();
                    celda.Text = "Numero de Tarjeta: ";
                    fila.Cells.Add(celda);
                    celda = new TableCell();
                    celda.Text = al.Huesped_.NumeroTarjeta;
                    fila.Cells.Add(celda);
                    Table1.Rows.Add(fila);

                    fila = new TableRow();
                    celda = new TableCell();
                    celda.Text = "Telefono: ";
                    fila.Cells.Add(celda);
                    celda = new TableCell();
                    celda.Text = al.Huesped_.Telefono;
                    fila.Cells.Add(celda);
                    Table1.Rows.Add(fila);

                    //Label3.Text = "Fecha_E: " + al.FechaEntrada.ToShortDateString() + " Fecha_S: " + al.FechaSalida.ToShortDateString() + "Imp_ad: " + al.ImporteServicios + "N: " + al.Huesped_.Nombre + "T: " + al.Huesped_.NumeroTarjeta + "Tel: " + al.Huesped_.Telefono;
                }
                
            }
            else Label3.Text = "Habitacion desocupada";
        }
    }
}