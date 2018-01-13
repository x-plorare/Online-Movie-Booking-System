using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Numerics;
using System.Collections;
using System.Web.Security;

namespace WebApplication10
{
    public partial class WebForm2 : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Customer_Id"] == null)
            {
                Response.Redirect("~/User-Info/Log-In.aspx");
            }
        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GridViewRow row = (GridViewRow)Session["Booking_Details"];
            string theater_name = row.Cells[1].Text;
            
            
            using(projectEntities1 context = new projectEntities1()){
                int noOfSeats = Int32.Parse(Session["noOfSeats"].ToString());
                
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
                    Button2.Enabled = true;

                    CheckBoxList1.Enabled = false;
                    CheckBoxList2.Enabled = false;
                    CheckBoxList3.Enabled = false;
                    CheckBoxList4.Enabled = false;
                    CheckBoxList5.Enabled = false;
                
                
                
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
        protected void Button2_Click(object sender, EventArgs e)
        {
            CheckBoxList1.Enabled = true;
            CheckBoxList2.Enabled = true;
            CheckBoxList3.Enabled = true;
            CheckBoxList4.Enabled = true;
            CheckBoxList5.Enabled = true;
            

            GridViewRow row = (GridViewRow)Session["Booking_Details"];
            //int show_id = Int32.Parse(row.Cells[6].Text);
            string theater_name = row.Cells[1].Text;
            using (projectEntities1 context = new projectEntities1())
            {
                //int noOfSeats = (from t in context.Theater_Info
                //                 where t.Theater_Name == theater_name
                //                 select t.Capacity).FirstOrDefault();
                System.Collections.ArrayList booked_tk = new ArrayList();
                //List<string> seatNos = ((from s in context.Show_Info
                //                         join b in context.Booking_Details on show_id equals b.Show_Id
                //                         join t in context.Seat_Details on b.Ticket_Id equals t.Ticket_Id
                //                         select t.Seat_No
                //                     ).Distinct()).ToList();
                //foreach (string i in seatNos)
                //{
                //    List<string> book_tk = i.Split(',').ToList();
                //    foreach (string j in book_tk)
                //    {
                //        booked_tk.Add(j.ToString());
                //    }
                //}
                System.Collections.ArrayList bookedInt_tk = new ArrayList();
                //foreach (string i in booked_tk)
                //{
                //    bookedInt_tk.Add(Int32.Parse(i));
                //}
                bookedInt_tk = (ArrayList)Session["BookedInt_Tk"];
                int cbl = CheckBoxList1.Items.Count;
                int bookedSize = bookedInt_tk.Count;
                int noOfSeats = Int32.Parse(Session["noOfSeats"].ToString());
                for (int i = 0; i < cbl; i++)
                {
                    for (int j = 0; j < bookedSize; j++)
                    {
                        if (CheckBoxList1.Items[i].Text.Equals(bookedInt_tk[j].ToString()))
                        {
                            CheckBoxList1.Items[i].Enabled = false;
                        }
                    }
                }
                for (int i = 0; i < cbl; i++)
                {
                    for (int j = 0; j < bookedSize; j++)
                    {
                        if (CheckBoxList2.Items[i].Text.Equals(bookedInt_tk[j].ToString()))
                        {
                            CheckBoxList2.Items[i].Enabled = false;
                        }
                    }
                }
                for (int i = 0; i < cbl; i++)
                {
                    for (int j = 0; j < bookedSize; j++)
                    {
                        if (CheckBoxList3.Items[i].Text.Equals(bookedInt_tk[j].ToString()))
                        {
                            CheckBoxList3.Items[i].Enabled = false;
                        }
                    }
                }
                for (int i = 0; i < cbl; i++)
                {
                    for (int j = 0; j < bookedSize; j++)
                    {
                        if (CheckBoxList4.Items[i].Text.Equals(bookedInt_tk[j].ToString()))
                        {
                            CheckBoxList4.Items[i].Enabled = false;
                        }
                    }
                }
                if (noOfSeats == 25)
                {
                    for (int i = 0; i < cbl; i++)
                    {
                        for (int j = 0; j < bookedSize; j++)
                        {
                            if (CheckBoxList5.Items[i].Text.Equals(bookedInt_tk[j].ToString()))
                            {
                                CheckBoxList5.Items[i].Enabled = false;
                            }
                        }
                    }
                }

                
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

            Session["seatNos"] = seatNos;
            

            Response.Redirect("WebForm3.aspx");
        }

        public void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Write("Successfully logged out");
            Response.Redirect("~/User-Info/Log-In.aspx");
        }
    }
}