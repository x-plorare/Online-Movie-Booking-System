using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

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

                    

                    Response.Write(noOfMovies);
                    
                    var selectionIdx = RadioButtonList1.SelectedIndex;
                    
                    RadioButtonList1.DataSource = (from m in context.Movie_Info
                                                   join s in context.Show_Info on m.Movie_Id equals s.Movie_Id
                                                   join t in context.Theater_Info on s.Theater_Id equals t.Theater_Id
                                                   where t.Location == DropDownList1.SelectedItem.Text
                                                   select m.Movie_Name).ToList();
                    RadioButtonList1.AutoPostBack = true;
                    RadioButtonList1.DataBind();

                    if ((noOfMovies-1) < selectionIdx)
                    {
                        selectionIdx = -1;
                    }

                    Response.Write(selectionIdx);
                    RadioButtonList1.SelectedIndex = 0 | selectionIdx;

                    if (RadioButtonList1.SelectedIndex > -1)
                    {
                        string selectedMovie = RadioButtonList1.SelectedItem.ToString();
                        GridView1.DataSource = (from s in context.Show_Info
                                                join m in context.Movie_Info on s.Show_Id equals m.Movie_Id
                                                join t in context.Theater_Info on s.Theater_Id equals t.Theater_Id
                                                where m.Movie_Name == selectedMovie && t.Location == DropDownList1.SelectedItem.Text
                                                select new
                                                {
                                                    t.Theater_Name,
                                                    m.Movie_Name,
                                                    s.Show_Date,
                                                    s.Start_Time,
                                                    s.Price
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
            Session["Theater_Name"] = GridView1.SelectedRow.Cells[1];
            Session["Movie_Name"] = GridView1.SelectedRow.Cells[2];
            Session["Show_Date"] = GridView1.SelectedRow.Cells[3];
            Session["Show_Time"] = GridView1.SelectedRow.Cells[4];
            Session["Price"] = GridView1.SelectedRow.Cells[5];

            Response.Redirect("WebForm2.aspx");
        }        
    }
}