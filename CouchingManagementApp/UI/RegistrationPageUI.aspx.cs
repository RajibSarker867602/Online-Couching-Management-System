using System;
using CouchingManagementApp.DAO;
using CouchingManagementApp.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CouchingManagementApp.UI
{
    public partial class RegistrationPageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            RegistrationFormEntryDao registrationFormEntryDao = new RegistrationFormEntryDao();
            registrationFormEntryDao.UserName = userNameTextBox.Text;
            registrationFormEntryDao.Password = passwordTextBox.Text;
            registrationFormEntryDao.ConfirmPassword = confirmpassword.Text;

            if (userNameTextBox.Text != "" && passwordTextBox.Text != "" && confirmpassword.Text != "")
            {
                RegistrationFormDal registrationFormDal = new RegistrationFormDal();
                string save = registrationFormDal.GetInsertOnDB(registrationFormEntryDao);
                if (save != null)
                {
                    userNameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    confirmpassword.Text = "";
                }
            }
            else
            {
                Response.Write("Input Field Empty!");
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/LoginPageUI.aspx");
        }
    }
}