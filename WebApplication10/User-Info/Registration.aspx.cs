using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Numerics;

namespace WebApplication10.User_Info
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (projectEntities1 context = new projectEntities1())
            {
                Customer_Info _insert = new Customer_Info();
                _insert.Customer_Name = TextBox1.Text;
                _insert.Email = TextBox2.Text;
                _insert.Customer_Password = TextBox3.Text;
                _insert.Phone_No = Decimal.Parse(TextBox4.Text);
                context.Customer_Info.Add(_insert);
                context.SaveChanges();
            }
            Response.Redirect("Log-In.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("facebookLogin.aspx");
        }
    }
}