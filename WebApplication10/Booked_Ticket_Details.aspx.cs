using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class Booked_Ticket_Details : System.Web.UI.Page
    {
//        public override int SaveChanges()
//        {
//            try
//            {
//                return base.SaveChanges();
//            }
//            catch (DbEntityValidationException e)
//            {
//                foreach (var eve in e.EntityValidationErrors)
//                {
//                    Debug.WriteLine(@"Entity of type ""{0}"" in state ""{1}"" 
//                   has the following validation errors:",
//                        eve.Entry.Entity.GetType().Name,
//                        eve.Entry.State);
//                    foreach (var ve in eve.ValidationErrors)
//                    {
//                        Debug.WriteLine(@"- Property: ""{0}"", Error: ""{1}""",
//                            ve.PropertyName, ve.ErrorMessage);
//                    }
//                }
//                throw;
//            }
//            catch (DbUpdateException e)
//            {
//                //Add your code to inspect the inner exception and/or
//                //e.Entries here.
//                //Or just use the debugger.
//                //Added this catch (after the comments below) to make it more obvious 
//                //how this code might help this specific problem
//            }
//            catch (Exception e)
//            {
//                Debug.WriteLine(e.Message);
//                throw;
//            }
//        }
        protected void Page_Load(object sender, EventArgs e)
        {

            DateTime todate = DateTime.UtcNow.Date;  
            string s1, s2, s3, s4, s5, seat;
            //int c_id = Int32.Parse(Session["Customer_Id"].ToString());
            int c_id = 3;
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
            using (projectEntities context = new projectEntities())
            {

                Booking_Details book = new Booking_Details();
                book.Customer_Id = c_id;
                book.Show_Id = show_id;
                book.No_Of_Tickets = aLen;
                book.Booking_Date = todate;
                context.Booking_Details.Add(book);
                context.SaveChanges();

                var tk_id = (from t in context.Show_Info
                                         join b in context.Booking_Details on show_id equals b.Show_Id
                                         join c in context.Customer_Info on c_id equals c.Customer_Id
                                         where b.Booking_Date == DbFunctions.TruncateTime(DateTime.UtcNow)
                                         select new
                                         {
                                             b.Ticket_Id
                                         }).OrderByDescending(t => t.Ticket_Id).FirstOrDefault();

                Payment_Info pay = new Payment_Info();
                pay.Ticket_Id = tk_id.Ticket_Id;
                pay.Total_Price = tot_price;
                pay.Mode = "PayPal";
                context.Payment_Info.Add(pay);
                context.SaveChanges();

                

                
            }


            
            switch (aLen)
            {
                case 1: s1 = seats.GetValue(0).ToString();
                    seat = s1;
                    break;

                case 2: s1 = seats.GetValue(0).ToString();
                    s2 = seats.GetValue(1).ToString();
                    seat = s1 + "," + s2;
                    break;

                case 3: s1 = seats.GetValue(0).ToString();
                    s2 = seats.GetValue(1).ToString();
                    s3 = seats.GetValue(2).ToString();
                    seat = s1 + "," + s2 + "," + s3;
                    break;

                case 4: s1 = seats.GetValue(0).ToString();
                    s2 = seats.GetValue(1).ToString();
                    s3 = seats.GetValue(2).ToString();
                    s4 = seats.GetValue(3).ToString();
                    seat = s1 + "," + s2 + "," + s3 + "," + s4;
                    break;

                case 5: s1 = seats.GetValue(0).ToString();
                    s2 = seats.GetValue(1).ToString();
                    s3 = seats.GetValue(2).ToString();
                    s4 = seats.GetValue(3).ToString();
                    s5 = seats.GetValue(4).ToString();
                    seat = s1 + "," + s2 + "," + s3 + "," + s4 + "," + s5;
                    break;

                default: seat = "No seat is selected";
                    break;
            }

            Label9.Text = Theater_Name;
            Label10.Text = Movie_Name;
            Label11.Text = Show_Date;
            Label12.Text = Show_Time;
            Label13.Text = aLen.ToString();
            Label14.Text = seat;
            Label15.Text = tot_price.ToString();
            Label16.Text = "Done";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}