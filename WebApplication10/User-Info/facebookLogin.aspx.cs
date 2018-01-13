using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.JScript;
using System.Web.Script.Serialization;

namespace WebApplication10.User_Info
{
    public partial class facebookLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DisplayEmail_ValueChanged(object sender, EventArgs e)
        {

        }

        protected void FBId_ValueChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FBId != null)
            {
                string email = DisplayEmail.ToString();

                using (projectEntities1 context = new projectEntities1())
                {
                    var customer_alt = (from c in context.Customer_Info
                                        where c.Email == email
                                        select c).ToList();

                    if (customer_alt != null)
                    {
                        Response.Redirect("default.aspx");
                    }
                }


                using (projectEntities1 context = new projectEntities1())
                {
                    Customer_Info customer = new Customer_Info();
                    customer.Customer_Name = displayname.ToString();
                    customer.Email = DisplayEmail.ToString();
                    customer.Customer_Password = FBId.ToString();
                    customer.Phone_No = 9876543546;

                    context.Customer_Info.Add(customer);
                    context.SaveChanges();

                    Session["Customer_Id"] = displayname.ToString();
                }
                Response.Redirect("~/default.aspx");
            }
        }
    }
}