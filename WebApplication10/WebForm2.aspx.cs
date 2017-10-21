using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Numerics;

namespace WebApplication10
{
    public partial class WebForm2 : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            //GridViewRow row = (GridViewRow)Session["Booking_Details"];
            //int show_id = Int32.Parse(row.Cells[6].Text);
            //using (projectEntities context = new projectEntities())
            //{
            //    Array seatNos = (from s in context.Show_Info
            //                      join b in context.Booking_Details on show_id equals b.Show_Id
            //                      join t in context.Seat_Details on b.Ticket_Id equals t.Ticket_Id
            //                      select new
            //                      {
            //                          t.Seat_No
            //                      }).ToArray();
            //}    
        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)Session["Booking_Details"];
            string theater_name = row.Cells[1].Text;
            using(projectEntities context = new projectEntities()){
                int noOfSeats =(from t in context.Theater_Info
                                    where t.Theater_Name == theater_name
                                    select t.Capacity).FirstOrDefault();
                Response.Write(theater_name);
                Response.Write(noOfSeats);

                switch (noOfSeats)
                {
                    case 5: CheckBoxList1.Visible = true;
                            break;

                    case 10: CheckBoxList1.Visible = true;
                            CheckBoxList2.Visible = true;
                            break;

                    case 15: CheckBoxList1.Visible = true;
                            CheckBoxList2.Visible = true;
                            CheckBoxList3.Visible = true;
                            break;

                    case 20: CheckBoxList1.Visible = true;
                            CheckBoxList2.Visible = true;
                            CheckBoxList3.Visible = true;
                            CheckBoxList4.Visible = true;
                            break;

                    case 25: CheckBoxList1.Visible = true;
                            CheckBoxList2.Visible = true;
                            CheckBoxList3.Visible = true;
                            CheckBoxList4.Visible = true;
                            CheckBoxList5.Visible = true;
                            break;
                }

                CheckBoxList1.Enabled = true;
                CheckBoxList2.Enabled = true;
                CheckBoxList3.Enabled = true;
                CheckBoxList4.Enabled = true;
                CheckBoxList5.Enabled = true;
                Button1.Enabled = false;
                Book.Enabled = false;
            }
        }

        protected void CheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCount1 = CheckBoxList1.Items.Cast<ListItem>().Count(li => li.Selected);
            int selectedCount2 = CheckBoxList2.Items.Cast<ListItem>().Count(li => li.Selected);
            int selectedCount3 = CheckBoxList3.Items.Cast<ListItem>().Count(li => li.Selected);
            int selectedCount4 = CheckBoxList4.Items.Cast<ListItem>().Count(li => li.Selected);
            int selectedCount5 = CheckBoxList5.Items.Cast<ListItem>().Count(li => li.Selected);
            int totalTickets = selectedCount1 + selectedCount2 + selectedCount3 + selectedCount4 + selectedCount5;
            int noOfTickets = Int32.Parse(RadioButtonList1.SelectedItem.Text);
            Book.Enabled = false;
            Button1.Enabled = false;

            //Response.Write(selectedCount1);
            //Respo nse.Write(selectedCount2);
            //Response.Write(selectedCount3);
            //Response.Write(selectedCount4);
            //Response.Write(selectedCount5);
            //Response.Write(noOfTickets);
            
            
            //Response.Write(totalTickets);
            if (totalTickets < noOfTickets)
            {
                CheckBoxList1.Enabled = true;
                CheckBoxList2.Enabled = true;
                CheckBoxList3.Enabled = true;
                CheckBoxList4.Enabled = true;
                CheckBoxList5.Enabled = true;
                Book.Enabled = false;
                Button1.Enabled = false;
            }
            else if (totalTickets == noOfTickets)
            {
                Button1.Enabled = true;
                Book.Enabled = false;
            }
            else if(totalTickets > 5){
                Button1.Enabled = false;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You can buy only five tickets at a time')", true);
            }
            else if (totalTickets > noOfTickets)
            {
                Button1.Enabled = false;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Increse no of Tickets')", true);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckBoxList1.Enabled = false;
            CheckBoxList2.Enabled = false;
            CheckBoxList3.Enabled = false;
            CheckBoxList4.Enabled = false;
            CheckBoxList5.Enabled = false;
            Book.Enabled = true;
        }

        protected void Book_Click(object sender, EventArgs e)
        {
            //int selectedCount1 = CheckBoxList1.Items.Cast<ListItem>().Count(li => li.Selected);
            //int selectedCount2 = CheckBoxList2.Items.Cast<ListItem>().Count(li => li.Selected);
            //int selectedCount3 = CheckBoxList3.Items.Cast<ListItem>().Count(li => li.Selected);
            //int selectedCount4 = CheckBoxList4.Items.Cast<ListItem>().Count(li => li.Selected);
            //int selectedCount5 = CheckBoxList5.Items.Cast<ListItem>().Count(li => li.Selected);
            //int totalTickets = selectedCount1 + selectedCount2 + selectedCount3 + selectedCount4 + selectedCount5;
            int noOfTickets = Int32.Parse(RadioButtonList1.SelectedItem.Text);
            
            int[] seatNos =  new int[noOfTickets];
            int j=0;
            foreach(ListItem i in CheckBoxList1.Items){
                if(i.Selected == true){
                    seatNos[j] = Int32.Parse(i.Text);
                    j++;
                    //Response.Write(i.Text);
                }
            }
            foreach (ListItem i in CheckBoxList2.Items)
            {
                if (i.Selected == true)
                {
                    seatNos[j] = Int32.Parse(i.Text);
                    j++;
                }
            }
            foreach (ListItem i in CheckBoxList3.Items)
            {
                if (i.Selected == true)
                {
                    seatNos[j] = Int32.Parse(i.Text);
                    j++;
                }
            }
            foreach (ListItem i in CheckBoxList4.Items)
            {
                if (i.Selected == true)
                {
                    seatNos[j] = Int32.Parse(i.Text);
                    j++;
                }
            }
            foreach (ListItem i in CheckBoxList5.Items)
            {
                if (i.Selected == true)
                {
                    seatNos[j] = Int32.Parse(i.Text);
                    
                    j++;
                }
            }
       
            for (int z = 0; z < j; z++)
            {
                Response.Write(seatNos[z]);
                Response.Write(",");
            }
            //Response.Write(totalTickets);   
            //Response.Write(noOfTickets);

            Session["seatNos"] = seatNos;
            

            Response.Redirect("WebForm3.aspx");
        }

        
    }
}