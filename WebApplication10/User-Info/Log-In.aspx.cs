using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10.User_Info
{
    public partial class Log_In : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

            using (projectEntities context = new projectEntities())
            {
                int customer = Int32.Parse((from c in context.Customer_Info
                                            where c.Customer_Name == Login1.UserName && c.Customer_Password == Login1.Password
                                            select c.Customer_Id).FirstOrDefault().ToString());

                Session["Customer_Id"] = customer;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);

            }
        }
    }
}