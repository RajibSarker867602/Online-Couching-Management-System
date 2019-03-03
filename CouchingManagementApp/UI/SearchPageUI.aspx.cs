using System;
using CouchingManagementApp.DAL;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CouchingManagementApp.UI
{
    public partial class SearchPageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(isFormValid())
                {
                    AddStudentEntryDao addStudentEntryDao = new AddStudentEntryDao();
                    addStudentEntryDao.RegistraionNo = registrationNoTextBox.Text;

                    SearchStudentByRegistrationNoDal searchStudentByRegistrationNo = new SearchStudentByRegistrationNoDal();
                    DataTable dt = searchStudentByRegistrationNo.StudentSearchByRegistrationNoDB(addStudentEntryDao);
                    if (dt.Rows.Count == 1)
                    {
                        studentRecordsGrid.DataSource = dt;
                        studentRecordsGrid.DataBind();
                    }
                    else
                    {
                        studentRecordsGrid.Visible = false;
                        Response.Write("There are no student found!");
                    }
                }
            }
            catch(Exception r)
            {
                Response.Write(r.Message);
            }
           
        }

        private bool isFormValid()
        {
            if(registrationNoTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Registration No Required!");
                registrationNoTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}