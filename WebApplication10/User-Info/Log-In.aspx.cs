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
            using (projectEntities1 context = new projectEntities1())
            {
                
                int customer = int.Parse((from c in context.Customer_Info
                                            where c.Customer_Name == Login1.UserName && c.Customer_Password == Login1.Password
                                            select c.Customer_Id).FirstOrDefault().ToString());

                if (customer > 0)
                {
                    Session["Customer_Id"] = customer;
                    //Login1.DestinationPageUrl = "~/default.aspx";
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("forgetPassword.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("facebookLogin.aspx");
        }
    }
}