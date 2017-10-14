using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string Theater_Name = Session["Theater_Name"].ToString(); 
            string Movie_Name = Session["Movie_Name"].ToString();
            var Show_Date = Session["Show_Date"];
            var Show_Time = Session["Show_Time"];
            var Price = Session["Price"];

            Response.Write(Theater_Name);
            Response.Write(Movie_Name);
            Response.Write(Show_Date);
            Response.Write(Show_Date);
            Response.Write(Price);
        }
    }
}