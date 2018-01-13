using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Customer_Id = int.Parse(Session["Customer_Id"].ToString());
            using (projectEntities1 context = new projectEntities1())
            {
                DetailsView1.DataSource = (from c in context.Customer_Info
                                           where c.Customer_Id == Customer_Id
                                           select new
                                           {
                                               c.Customer_Name,
                                               c.Customer_Password,
                                               c.Email,
                                               c.Phone_No
                                           }).ToList();
                DetailsView1.AutoGenerateEditButton = true;
                DetailsView1.DataBind();

                //Customer_Info customer = (from c in context.Customer_Info
                //                          where c.Customer_Id == Customer_Id
                //                          select c).First();
                                        

                //Name.Text = customer.Customer_Name;
                //Email.Text = customer.Email;
                //Password.Text = customer.Customer_Password;
                //Phone_No.Text = customer.Phone_No.ToString();
            }
        }

        protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
        {
            DetailsView1.DefaultMode = DetailsViewMode.Edit;
            DetailsView1.DataBind();
        }

        protected void DetailsViewParentsDetails_ItemCommand(object sender, DetailsViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edit"))
            {
                this.DetailsView1.ChangeMode(DetailsViewMode.Edit);
                this.DetailsView1.DataBind();
            }
            else if (e.CommandName.Equals("Cancel"))
            {
                this.DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
                this.DetailsView1.DataBind();
            }
        }

        protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {
            int Customer_Id = int.Parse(Session["Customer_Id"].ToString());

            for (int i = 0; i < e.NewValues.Count; i++)
            {

                if (e.NewValues[i] != null)
                {
                    e.NewValues[i] = Server.HtmlEncode(e.NewValues[i].ToString());
                }
            }
            using(projectEntities1 context = new projectEntities1())
            {
                Customer_Info customer = context.Customer_Info.FirstOrDefault(i => i.Customer_Id == Customer_Id);

                customer.Customer_Name = e.NewValues[0].ToString();
                customer.Customer_Password = e.NewValues[1].ToString();
                customer.Email = e.NewValues[2].ToString();
                customer.Phone_No = Convert.ToDecimal(e.NewValues[3].ToString());

                context.SaveChanges();
            }
        }

        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            DetailsView1.DataBind();
        }

        public void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Write("Successfully logged out");
            Response.Redirect("~/User-Info/Log-In.aspx");
        }


        private List<Customer_Info> GetCustomerInfo(string custname)
        {
            using (projectEntities1 context = new projectEntities1())
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
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int Customer_Id = int.Parse(Session["Customer_Id"].ToString());
            string name = Name.Text;
            string password = Password.Text;
            string email = Email.Text;
            decimal phone_no = Decimal.Parse(Phone_No.Text);
            using (projectEntities1 context = new projectEntities1())
            {
                Customer_Info customer = context.Customer_Info.FirstOrDefault(s => s.Customer_Id == Customer_Id);
                customer.Customer_Password = password;
                customer.Email = email;
                customer.Phone_No = phone_no;
                context.SaveChanges();
            }   
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