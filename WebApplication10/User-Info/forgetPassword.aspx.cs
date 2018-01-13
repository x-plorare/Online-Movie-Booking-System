using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication10.User_Info
{
    public partial class forgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Log-In.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextBox1.Text;
            using (projectEntities1 context = new projectEntities1())
            {
                var user = (from c in context.Customer_Info
                            where c.Email == email
                            select c).FirstOrDefault();


                if (user != null)
                {
                    string username = user.Customer_Name;
                    string password = user.Customer_Password;
                    Application OutlookApplication = new Application();


                    MailItem message = (MailItem)OutlookApplication.CreateItem(OlItemType.olMailItem);

                    MailAddress toAddress = new MailAddress(email);


                    message.To = toAddress.ToString();  
                    message.Subject = "Password Recovery";
                    message.HTMLBody = "Your Username is:" + username + "<br/><br/>" + "Your Password is:" + password;
                    message.BodyFormat = OlBodyFormat.olFormatHTML;

                    message.Send();

                    //MailMessage msg = new MailMessage();
                    //msg.From = new MailAddress("dhairyanadapara@outlook.com");
                    //msg.To.Add(email);
                    //msg.Subject = " Recover your Password";
                    //msg.Body = ("Your Username is:" + username + "<br/><br/>" + "Your Password is:" + password);
                    //msg.IsBodyHtml = true;

                    //SmtpClient smt = new SmtpClient();
                    //smt.Host = "smtp.gmail.com";
                    //System.Net.NetworkCredential ntwd = new NetworkCredential();
                    //ntwd.UserName = "dhairyanadapara@outlook.com";
                    //ntwd.Password = "#dpn@26011998"; 
                    //smt.UseDefaultCredentials = true;
                    //smt.Credentials = ntwd;
                    //smt.Port = 587;
                    //smt.EnableSsl = true;
                    //smt.Send(msg);

                    //Label2.Text = "Username and Password Sent Successfully";
                    //Label2.ForeColor = System.Drawing.Color.ForestGreen;
                }
            }
        }
    }
}