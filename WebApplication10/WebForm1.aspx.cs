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
            if (IsPostBack)
            {
                using (projectEntities context = new projectEntities())
                {

                    int noOfMovies = (from t in context.Theater_Info
                                      join s in context.Show_Info on t.Theater_Id equals s.Theater_Id
                                      where t.Location == DropDownList1.SelectedItem.Text
                                            select s.Theater_Id).Cast<int>().Count();

                    

                    //Response.Write(noOfMovies);
                    
                    var selectionIdx = RadioButtonList1.SelectedIndex;

                    RadioButtonList1.DataSource = (from m0 in context.Movie_Info
                                                   join s0 in context.Show_Info on m0.Movie_Id equals s0.Movie_Id
                                                   join t0 in context.Theater_Info on s0.Theater_Id equals t0.Theater_Id
                                                   where t0.Location == DropDownList1.SelectedItem.Text
                                                   select m0.Movie_Name).ToList();
                    //RadioButtonList1.AutoPostBack = true;
                    RadioButtonList1.DataBind();

                    if ((noOfMovies-1) < selectionIdx)
                    {
                        selectionIdx = -1;
                    }

                    //Response.Write(selectionIdx);
                    RadioButtonList1.SelectedIndex = 0 | selectionIdx;

                    if (RadioButtonList1.SelectedIndex > -1)
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
                    else
                    {
                        RadioButtonList1.SelectedIndex = 0;
                    }
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HttpContext.Current.Session["Theater_Name"] = 
            Response.Write(GridView1.SelectedRow.Cells[1]);
            Session["Movie_Name"] = GridView1.SelectedRow.Cells[2];
            Session["Show_Date"] = GridView1.SelectedRow.Cells[3];
            Session["Show_Time"] = GridView1.SelectedRow.Cells[4];
            Session["Price"] = GridView1.SelectedRow.Cells[5];

            //Response.Redirect("WebForm2.aspx");
        }        
    }
}