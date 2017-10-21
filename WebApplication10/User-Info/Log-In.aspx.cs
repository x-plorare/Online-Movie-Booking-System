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
            String str = WebConfigurationManager.ConnectionStrings["online-ticket-databaseConnectionString"].ConnectionString;
            SqlConnection myconn = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myconn;
            cmd.CommandText = "Select * from Customer_Info";
            myconn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (Login1.UserName == rdr["Customer_Name"].ToString() && Login1.Password == rdr["Customer_Password"].ToString())
            {
                Session["Customer_Name"] = Login1.UserName;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
                Session.RemoveAll();
            }
            myconn.Close();
        }
    }
}