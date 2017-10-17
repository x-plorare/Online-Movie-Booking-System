using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                using (projectEntities context = new projectEntities())
                {
                    RadioButtonList1.DataSource = (from m0 in context.Movie_Info
                                                   join s0 in context.Show_Info on m0.Movie_Id equals s0.Movie_Id
                                                   join t0 in context.Theater_Info on s0.Theater_Id equals t0.Theater_Id
                                                   where t0.Location == DropDownList1.SelectedItem.Text
                                                   select m0.Movie_Name).ToList().Distinct();

                    RadioButtonList1.DataBind();
                }
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (projectEntities context = new projectEntities())
            {

                string selectedMovie = RadioButtonList1.SelectedItem.ToString();
                GridView1.DataSource = (from s1 in context.Show_Info
                                        join t1 in context.Theater_Info on DropDownList1.SelectedItem.Text equals t1.Location
                                        join m1 in context.Movie_Info on selectedMovie equals m1.Movie_Name
                                        where s1.Movie_Id == m1.Movie_Id && s1.Theater_Id == t1.Theater_Id
                                        select new
                                        {
                                            t1.Theater_Name,
                                            m1.Movie_Name,
                                            s1.Show_Date,
                                            s1.Start_Time,
                                            s1.Price
                                        }).ToList();
                GridView1.AutoGenerateSelectButton = true;
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            GridViewRow row = GridView1.SelectedRow;
            Session["Booking_Details"] = row;

            //var row = GridView1.SelectedRow.DataItemIndex;
            //Response.Write(row);
            //Session["Theater_Name"] = GridView1.Rows[row].Cells[1].Text;
            //Session["Movie_Name"] = GridView1.Rows[row].Cells[2].Text;
            //Session["Show_Date"] = GridView1.Rows[row].Cells[3].Text;
            //Session["Show_Time"] = GridView1.Rows[row].Cells[4].Text;
            //Session["Price"] = GridView1.Rows[row].Cells[5].Text;

            Response.Redirect("WebForm2.aspx");
        }
    }    
}