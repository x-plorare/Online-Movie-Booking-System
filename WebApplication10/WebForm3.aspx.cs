using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s1,s2,s3,s4,s5,seat;
            GridViewRow row = (GridViewRow)Session["Booking_Details"];
            string Theater_name = row.Cells[1].Text;
            string Movie_Name = row.Cells[2].Text;
            var Show_Date = row.Cells[3].Text;
            var Show_Time = row.Cells[4].Text;
            decimal Price = Decimal.Parse(row.Cells[5].Text);
            Array seats = (Array)Session["seatNos"]; 
            int aLen = seats.Length;
            switch(aLen){
                case 1:s1 = seats.GetValue(0).ToString();
                    seat = s1;
                    break;

                case 2:s1 = seats.GetValue(0).ToString();
                    s2 = seats.GetValue(1).ToString();
                    seat = s1 + "," + s2;
                    break;

                case 3:s1 = seats.GetValue(0).ToString();
                    s2 = seats.GetValue(1).ToString();
                    s3 = seats.GetValue(2).ToString();
                    seat = s1 + "," + s2 + "," + s3;
                    break;
            
                case 4:s1 = seats.GetValue(0).ToString();
                    s2 = seats.GetValue(1).ToString();
                    s3 = seats.GetValue(2).ToString();
                    s4 = seats.GetValue(3).ToString();
                    seat = s1 + "," + s2 + "," + s3 + "," + s4;
                    break;

                case 5:s1 = seats.GetValue(0).ToString();
                    s2 = seats.GetValue(1).ToString();
                    s3 = seats.GetValue(2).ToString();
                    s4 = seats.GetValue(3).ToString();
                    s5 = seats.GetValue(4).ToString();
                    seat = s1 + "," + s2 + "," + s3 + "," + s4 + "," + s5;
                    break;

                default: seat = "No seat is selected";
                    break;
                    }

            Label6.Text = Theater_name;
            Label7.Text = Movie_Name;
            Label8.Text = Show_Date;
            Label9.Text = Show_Time;
            Label10.Text = Price.ToString();

            Label12.Text = seat;

            Label14.Text = (Price * aLen).ToString(); 
        }
    }
}