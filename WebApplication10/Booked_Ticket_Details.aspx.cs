using Microsoft.Office.Interop.Outlook;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class Booked_Ticket_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Customer_Id"] == null)
            {
                Response.Redirect("~/User-Info/Log-In.aspx");
            }
            if (!IsPostBack)
            {
                DateTime todate = DateTime.UtcNow.Date;
                int customerId = Int32.Parse(Session["Customer_Id"].ToString());
                GridViewRow row = (GridViewRow)Session["Booking_Details"];
                string Theater_Name = row.Cells[1].Text;
                string Movie_Name = row.Cells[2].Text;
                var Show_Date = row.Cells[3].Text;
                var Show_Time = row.Cells[4].Text;
                decimal Price = Decimal.Parse(row.Cells[5].Text);
                Array seats = (Array)Session["seatNos"];
                int show_id = Int32.Parse(row.Cells[6].Text);
                int aLen = seats.Length;
                decimal tot_price = aLen * Price;
                string seatStr = Session["seatStr"].ToString();
                using (projectEntities1 context = new projectEntities1())
                {

                    Booking_Details book = new Booking_Details();
                    book.Customer_Id = customerId;
                    book.Show_Id = show_id;
                    book.No_Of_Tickets = aLen;
                    book.Booking_Date = todate;
                    context.Booking_Details.Add(book);
                    context.SaveChanges();



                    var tk_id = (from t in context.Show_Info
                                 join b in context.Booking_Details on show_id equals b.Show_Id
                                 join c in context.Customer_Info on customerId equals c.Customer_Id
                                 where b.Booking_Date == DbFunctions.TruncateTime(DateTime.UtcNow)
                                 select new
                                 {
                                     b.Ticket_Id
                                 }).OrderByDescending(t => t.Ticket_Id).FirstOrDefault();



                    Seat_Details seatno = new Seat_Details();
                    Payment_Info pay = new Payment_Info();
                    pay.Ticket_Id = seatno.Ticket_Id = tk_id.Ticket_Id;
                    seatno.Seat_No = seatStr;
                    context.Seat_Details.Add(seatno);
                    pay.Total_Price = tot_price;
                    pay.Mode = "PayPal";
                    context.Payment_Info.Add(pay);
                    context.SaveChanges();

                    var user = (from c in context.Customer_Info
                                where c.Customer_Id == customerId
                                select c).FirstOrDefault();

                    Application OutlookApplication = new Application();


                    MailItem message = (MailItem)OutlookApplication.CreateItem(OlItemType.olMailItem);

                    MailAddress toAddress = new MailAddress(user.Email);


                    message.To = toAddress.ToString();
                    message.Subject = "Movie Ticket";
                    message.HTMLBody ="<h1>THANK YOU for using Let's book</h1>" + "<br/><br/>" + "Theater Name:" + "<br/><br/>" + Theater_Name + "Movie:" + Movie_Name + "<br/><br/>" + "Show Date:" + Show_Date + "<br/><br/>" + "Show Time:" + Show_Time + "<br/><br/>" + "No of Tickets:" + aLen.ToString() + "<br/><br/>" + "Seat Numbers:" + seatStr + "<br/><br/>" + "Price" + Price + "<br/><br/>" + "Enjoy your show";
                    message.BodyFormat = OlBodyFormat.olFormatHTML;

                    message.Send();
                }

                Label9.Text = Theater_Name;
                Label10.Text = Movie_Name;
                Label11.Text = Show_Date;
                Label12.Text = Show_Time;
                Label13.Text = aLen.ToString();
                Label14.Text = seatStr;
                Label15.Text = tot_price.ToString();
                Label16.Text = "Done";


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }

        public void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Write("Successfully logged out");
            Response.Redirect("~/User-Info/Log-In.aspx");
        }
    }
}