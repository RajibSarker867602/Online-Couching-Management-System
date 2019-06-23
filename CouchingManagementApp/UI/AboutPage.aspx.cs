using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CouchingManagementApp.UI
{
    public partial class AboutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string name = nameTextBox.Text;
            //    string emailAddress = emailTextBox.Text;
            //    string comment = commentTextBox.Text;

            //    MailMessage message = new MailMessage(emailAddress, "RajibSarker3202@gmail.com", name, comment);
            //    message.IsBodyHtml = true;

            //    SmtpClient client = new SmtpClient("smtp.gmal.com", 587);
            //    client.EnableSsl = true;
            //    client.Credentials = new System.Net.NetworkCredential("RajibSarker3202@gmal.com", "");
            //    client.Send(message);
            //    msgLabel.Text = "Your message sent successfully.";
            //}
            //catch(Exception r)
            //{
            //    msgLabel.Text = r.StackTrace;
            //}
            try
            {
                if(isFormValid())
                {
                    string name = nameTextBox.Text;
                    string fromEmailAddress = emailTextBox.Text;
                    string comment = commentTextBox.Text;
                    string mess = name + "+" + fromEmailAddress;

                    MailMessage message = new MailMessage(emailTextBox.Text, "RajibSarker3202@gmail.com", mess, commentTextBox.Text);
                    message.IsBodyHtml = true;


                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Credentials = new System.Net.NetworkCredential("RajibSarker3202@gmail.com", "Your_Password");

                    client.Send(message);
                    msgLabel.Text = "Thank You For Your Feedback.";
                    nameTextBox.Text = string.Empty;
                    emailTextBox.Text = string.Empty;
                    commentTextBox.Text = string.Empty;
                }
            }
            catch (Exception r)
            {
                msgLabel.Text = r.StackTrace;
            }
        }

        private bool isFormValid()
        {
            if(nameTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Please Enter Your Name!");
                nameTextBox.Focus();
                return false;
            }
            if(emailTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Please Enter Your Valid Email Address!");
                emailTextBox.Focus();
                return false;
            }
            if(commentTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Please Write Your Comment!");
                commentTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
