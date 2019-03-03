using System;
using System.Data;
using System.Data.SqlClient;
using CouchingManagementApp.DAL;
using CouchingManagementApp.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CouchingManagementApp.UI
{
    public partial class FeesPageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        AddStudentEntryDao addFeeDao = new AddStudentEntryDao();

        protected void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(isFormValid())
                {
                    addFeeDao.RegistraionNo = registrationNoTextBox.Text;
                    addFeeDao.CourseFee = Convert.ToInt32(courseFeeLabel.Text);
                    addFeeDao.AddFee = Convert.ToInt32(addedFeeTextBox.Text);
                    addFeeDao.PaidFee = Convert.ToInt32(paidFeeLabel.Text);
                    addFeeDao.RemainingFee = Convert.ToInt32(remainingFeeLabel.Text);
                    if (addFeeDao.AddFee <= addFeeDao.RemainingFee)
                    {
                        addFeeDao.PaidFee += addFeeDao.AddFee;
                        addFeeDao.RemainingFee = addFeeDao.CourseFee - addFeeDao.PaidFee;

                        UpdateStudentFeeDal updateStudentFeeDal = new UpdateStudentFeeDal();
                        string update = updateStudentFeeDal.GetUpdateStudentFeeDB(addFeeDao);
                        if (update != null)
                        {
                            registrationNoTextBox.Text = "";
                            nameLabel.Text = "Name Will Be Display Here";
                            emailLabel.Text = "Email Address Will Be Display Here";
                            courseNameLabel.Text = "Course Name Will Be Display Here";
                            courseFeeLabel.Text = "Course Fee Will Be Display Here";
                            paidFeeLabel.Text = "Paid Fee Will Be Display Here";
                            remainingFeeLabel.Text = "Remaining Fee Will Be Display Here";
                            addedFeeTextBox.Text = "";
                        }
                    }
                    else
                    {
                        Response.Write("Your added amount is too large!");
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

        protected void registrationNoTextBox_TextChanged(object sender, EventArgs e)
        {
            addFeeDao.RegistraionNo = registrationNoTextBox.Text;

            SearchStudentByRegistrationNoDal searchStudentByRegistrationNoDal = new SearchStudentByRegistrationNoDal();
            DataTable dt = searchStudentByRegistrationNoDal.StudentSearchByRegistrationNoDB(addFeeDao);
            if (dt.Rows.Count > 0)
            {
                //nameLabel.Text = dt.Rows[0]["Student_Name"].ToString();
                //emailLabel.Text = dt.Rows[0]["Email"].ToString();
                //courseNameLabel.Text = dt.Rows[0]["Selected_Course"].ToString();
                //courseFeeLabel.Text = dt.Rows[0]["Course_Fee"].ToString();

                //paidFeeLabel.Text = dt.Rows[0]["Paid_Fee"].ToString();
                //remainingFeeLabel.Text = dt.Rows[0]["Remaining_Fee"].ToString();
                //if(Convert.ToInt32(remainingFeeLabel.Text)==0)
                //{
                //    addedFeeTextBox.ReadOnly = true;
                //    addButton.Enabled = false;
                //}

                addFeeDao.StudentName = dt.Rows[0]["Student_Name"].ToString();
                addFeeDao.Email = dt.Rows[0]["Email"].ToString();
                addFeeDao.SelectedCourse = dt.Rows[0]["Selected_Course"].ToString();
                addFeeDao.CourseFee = Convert.ToInt32(dt.Rows[0]["Course_Fee"].ToString());

                if (dt.Rows[0]["Paid_Fee"] != null && dt.Rows[0]["Paid_Fee"].ToString() !="")
                {
                    addFeeDao.PaidFee = Convert.ToInt32(dt.Rows[0]["Paid_Fee"].ToString());
                    addFeeDao.RemainingFee = Convert.ToInt32(dt.Rows[0]["Remaining_Fee"]);
                }
                else
                {
                    addFeeDao.PaidFee = 0;
                    addFeeDao.RemainingFee = addFeeDao.CourseFee-addFeeDao.PaidFee;
                }
                nameLabel.Text = addFeeDao.StudentName;
                emailLabel.Text = addFeeDao.Email;
                courseNameLabel.Text = addFeeDao.SelectedCourse;
                courseFeeLabel.Text = addFeeDao.CourseFee.ToString();
                paidFeeLabel.Text = addFeeDao.PaidFee.ToString();
                remainingFeeLabel.Text = addFeeDao.RemainingFee.ToString();

                if(addFeeDao.RemainingFee==0)
                {
                    addedFeeTextBox.ReadOnly = true;
                    addButton.Enabled = false;
                }
                else
                {
                    addedFeeTextBox.ReadOnly = false;
                    addButton.Enabled = true;
                }

            }
            else
            {
                nameLabel.Text = "Not Found!";
                emailLabel.Text = "Not Found!";
                courseNameLabel.Text = "Not Found!";
                courseFeeLabel.Text = "Not Found!";
                paidFeeLabel.Text = "Not Found!";
                remainingFeeLabel.Text = "Not Found!";
                addedFeeTextBox.ReadOnly = true;
                addButton.Enabled = false;
            }
        }
    }
}