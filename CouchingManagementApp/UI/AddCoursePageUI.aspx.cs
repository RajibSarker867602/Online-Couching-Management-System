using System;
using CouchingManagementApp.DAL;
using CouchingManagementApp.DAO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CouchingManagementApp
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(isFormValid())
                {
                    CourseDetailsEntryDao courseDetailsEntryDao = new CourseDetailsEntryDao();
                    courseDetailsEntryDao.CourseName = courseNameTextBox.Text;
                    courseDetailsEntryDao.CourseFee = Convert.ToInt32(courseFeeTextBox.Text);
                    courseDetailsEntryDao.Duration = courseDurationDdlist.SelectedItem.Text;

                    IsExistCourseNameDal isExistCourseNameDal = new IsExistCourseNameDal();
                    DataTable dt = isExistCourseNameDal.IsExistCourseNameInDB(courseDetailsEntryDao);
                    if (dt.Rows.Count == 0)
                    {
                        CourseDetailsEntryDal courseDetailsEntryDal = new CourseDetailsEntryDal();
                        string save = courseDetailsEntryDal.GetInsertInDb(courseDetailsEntryDao);
                        if (save != null)
                        {
                            courseNameTextBox.Text = "";
                            courseFeeTextBox.Text = "";
                            courseDurationDdlist.ClearSelection();
                        }
                    }
                    else
                    {
                        Response.Write("Course Name Is Exist!");    //Course Details Update Once Again....
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
            if(courseNameTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Course Name Required!");
                courseNameTextBox.Focus();
                return false;
            }
            if(courseFeeTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Course Fee Required!");
                courseFeeTextBox.Focus();
                return false;
            }
            if(courseDurationDdlist.SelectedIndex==0)
            {
                Response.Write("Select Your Course Duration!");
                courseDurationDdlist.Focus();
                return false;
            }
            return true;
        }
    }
}