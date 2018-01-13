using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class Booked_Tickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Customer_Id"] == null)
            {
                Response.Redirect("~/User-Info/Log-In.aspx");
            }
            using (projectEntities1 context = new projectEntities1())
            {
                int customerId = Int32.Parse(Session["Customer_Id"].ToString());
                GridView1.DataSource = (from b in context.Booking_Details
                                        join c in context.Customer_Info on b.Customer_Id equals c.Customer_Id
                                        join s in context.Seat_Details on b.Ticket_Id equals s.Ticket_Id
                                        where c.Customer_Id == customerId
                                        select new
                                        {
                                            b.Show_Info.Theater_Info.Theater_Name,
                                            b.Show_Info.Movie_Info.Movie_Name,
                                            b.Show_Info.Show_Date,
                                            b.Show_Info.Start_Time,
                                            b.No_Of_Tickets,
                                            s.Seat_No,
                                            b.Ticket_Id
                                        }).ToList();
                GridView1.DataBind();
            }
        }
        public void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Write("Successfully logged out");
            Response.Redirect("~/User-Info/Log-In.aspx");
        }
    }
}
