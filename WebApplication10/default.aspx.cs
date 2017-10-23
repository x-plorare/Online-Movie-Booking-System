using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10.User_Info
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Write("Successfully logged out");
            Response.Redirect("Login.aspx");
        }



        private List<Customer_Info> GetCustomerInfo(string custname)
        {
            using (projectEntities context = new projectEntities())
            {
                return (from c in context.Customer_Info
                        where c.Customer_Name == custname
                        select c).ToList();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {




        }


        protected void Button5_Click(object sender, EventArgs e)
        {
            var customerInfo = GetCustomerInfo(Context.User.Identity.Name);
            Name.Text = customerInfo[0].Customer_Name;
            Email.Text = customerInfo[0].Email;
            Password.Text = customerInfo[0].Customer_Password;
            Phone_No.Text = customerInfo[0].Phone_No.ToString();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            projectEntities context = new projectEntities();
            Customer_Info s1 = context.Customer_Info.FirstOrDefault(s => s.Customer_Name == Context.User.Identity.Name);
            s1.Customer_Password = Password.Text;
            s1.Customer_Name = Name.Text;
            s1.Phone_No = Decimal.Parse(Phone_No.Text);
            context.SaveChanges();

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ticket_Cancellation.aspx");
        }
    }
}