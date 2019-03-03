using System;
using System.Data;
using System.Data.SqlClient;
using CouchingManagementApp.DAO;
using CouchingManagementApp.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CouchingManagementApp.UI
{
    public partial class LoginPageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createNewAccountButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/RegistrationPageUI.aspx");
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            RegistrationFormEntryDao registrationFormEntryDao = new RegistrationFormEntryDao();
            registrationFormEntryDao.UserName = userNameTextBox.Text;
            registrationFormEntryDao.Password = passwordTextBox.Text;

            if (userNameTextBox.Text.Trim() != "" && passwordTextBox.Text.Trim() != "")
            {
                LoginFormDal loginFormDal = new LoginFormDal();
                DataTable dt = loginFormDal.GetUserMatchOnDB(registrationFormEntryDao);
                if (dt.Rows.Count > 0)
                {
                    Response.Redirect("~/UI/HomePage.aspx");
                }
                else
                {
                    Response.Write("Password Dose Not Match!");
                }
            }
            else
            {
                Response.Write("Input Field Empty!");
            }

        }
    }
}