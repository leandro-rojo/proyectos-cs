using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernate;
using Iesi.Collections;

namespace Hotel
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }
        private bool validarLogin(string usr,string pass)
        {
            if(usr.Equals("admin")&&pass.Equals("admin"))
            {
                return true;
            }
            return false;
        }
        protected void moztrologin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            e.Authenticated = validarLogin(Login1.UserName, Login1.Password);
            if (e.Authenticated)
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
        }
    }
}