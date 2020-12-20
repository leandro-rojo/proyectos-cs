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
    public partial class Registrar : System.Web.UI.Page
    {
        ISessionFactory sesiones;
        ISession sesion;

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox3.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sesiones = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            sesion = sesiones.OpenSession();
            bool a = false;
            if(TextBox3.Text!="")
            {
                if(TextBox2.Text!="")
                    if(TextBox4.Text!="")
                        if(TextBox5.Text!="")
                        {
                            Huesped h = new Huesped();
                            h.Nombre = TextBox3.Text;
                            h.NumeroTarjeta = TextBox2.Text;
                            h.Dni = TextBox4.Text;
                            h.Direccion = TextBox5.Text;
                            h.Telefono = TextBox6.Text;
                            sesion.Save(h);
                            sesion.Flush();
                            a = true;
                        }
            }
            if(!a)
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label2.ForeColor = System.Drawing.Color.Red;
                Label3.ForeColor = System.Drawing.Color.Red;
                Label4.ForeColor = System.Drawing.Color.Red;
                Label6.ForeColor = System.Drawing.Color.Red;
                Label6.Text = "Rellene los campos obligatorios";
            }
            else
            {
                Label6.ForeColor = System.Drawing.Color.DarkSeaGreen;
                Label6.Text = "huesped registrado";
            }
            //sesion.Update(h, 1);
        }
    }
}