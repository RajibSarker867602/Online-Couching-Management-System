using System;
using System.Data;
using System.Data.SqlClient;
using CouchingManagementApp.DAO;
using CouchingManagementApp.DAL;
using CouchingManagementApp.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CouchingManagementApp.UI
{
    public partial class AddSutdentPageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                courseListDdList.Items.Clear();
                teachersDdList.Items.Add("--Empty List--");
                LoadCourseList();
            }
        }

        private void LoadCourseList()
        {
            AllCourseOnDdListDal allCourseList = new AllCourseOnDdListDal();
            DataTable dt = allCourseList.GetAllCourseNameDB();
            if(dt.Rows.Count>0)
            {
                courseListDdList.Items.Clear();
                courseListDdList.Items.Add("--Select--");
                foreach (DataRow dr in dt.Rows)
                {
                    courseListDdList.Items.Add(new ListItem(dr["Course_Name"].ToString(), dr["Course_Name"].ToString()));
                }
            }
            else
            {
                courseListDdList.Items.Clear();
                courseListDdList.Items.Add("--Emptry List--");
            }
        }

        protected void courseListDdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TeacherDetailsEntryDao teacherDetailsDao = new TeacherDetailsEntryDao();
            teacherDetailsDao.Subject = courseListDdList.SelectedItem.Text;

            GetCourseFeeDal getCourseFee = new GetCourseFeeDal();
            teacherDetailsDao.Subject= courseListDdList.SelectedItem.Text;
            DataTable getFee = getCourseFee.GetCourseFee(teacherDetailsDao);
            if(getFee.Rows.Count>0)
            {
                courseFeeLabel.Text = getFee.Rows[0]["Course_Fee"].ToString();
            }
            else
            {
                courseFeeLabel.Text = "No Fees Found!";
            }

            TeacherListOnStudentDdlListDal teacherList = new TeacherListOnStudentDdlListDal();
            DataTable dt = teacherList.GetAllTeacherByDdlDB(teacherDetailsDao);
            if(dt.Rows.Count>0)
            {
                teachersDdList.Items.Clear();
                teachersDdList.Items.Add("--Select--");
                foreach(DataRow dr in dt.Rows)
                {
                    teachersDdList.Items.Add(new ListItem(dr["Teacher_Name"].ToString(), dr["Subject"].ToString()));
                }
            }
            else
            {
                teachersDdList.Items.Clear();
                teachersDdList.Items.Add("--Empty List--");
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(isFormValid())
                {
                    AddStudentEntryDao addStudentEntryDao = new AddStudentEntryDao();
                    addStudentEntryDao.StudentName = studentNameTextBox.Text;
                    addStudentEntryDao.Address = addressTextBox.Text;
                    addStudentEntryDao.Email = emailTextBox.Text;
                    addStudentEntryDao.Date = startDateTextBox.Text;
                    addStudentEntryDao.SelectedCourse = courseListDdList.SelectedItem.Text;
                    addStudentEntryDao.SelectedTeacher = teachersDdList.SelectedItem.Text;
                    addStudentEntryDao.RegistraionNo = registrationNumberLabel.Text;
                    addStudentEntryDao.CourseFee = Convert.ToInt32(courseFeeLabel.Text);

                    AddStudentEntryDal addStudentEntryDal = new AddStudentEntryDal();
                    string save = addStudentEntryDal.AddstudentDB(addStudentEntryDao);
                    if (save != null)
                    {
                        studentNameTextBox.Text = "";
                        addressTextBox.Text = "";
                        emailTextBox.Text = "";
                        courseListDdList.ClearSelection();
                        teachersDdList.ClearSelection();
                        startDateTextBox.Text = "";
                        registrationNumberLabel.Text = "Registration Number Will Be Display Here";
                        courseFeeLabel.Text = "Course Fee Will Be Display Here";
                    }
                    else
                    {
                        Response.Write("There are some problem fixed! Please try again later...");
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
            if(studentNameTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Student Name Required!");
                studentNameTextBox.Focus();
                return false;
            }
            if(addressTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Address Field Required!");
                addressTextBox.Focus();
                return false;
            }
            if(emailTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Email Required!");
                emailTextBox.Focus();
                return false;
            }
            if(startDateTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Started Date Required!");
                startDateTextBox.Focus();
                return false;
            }
            if(courseListDdList.SelectedIndex==0)
            {
                Response.Write("Select Your Course!");
                courseListDdList.Focus();
                return false;
            }
            if(teachersDdList.SelectedIndex==0)
            {
                Response.Write("Select Your Teacher!");
                teachersDdList.Focus();
                return false;
            }
            return true;
        }

        protected void startDateTextBox_TextChanged(object sender, EventArgs e)
        {
            AddStudentEntryDao addStudentDao = new AddStudentEntryDao();
            addStudentDao.SelectedCourse = courseListDdList.SelectedItem.Text;
            addStudentDao.Date = startDateTextBox.Text;
            addStudentDao.SelectedTeacher = teachersDdList.SelectedItem.Text;

            StudentRegstraionNoBll studentRegistrationBll = new StudentRegstraionNoBll();
            addStudentDao.RegistraionNo = studentRegistrationBll.GetStudentRegistraionNo(addStudentDao);
            if (addStudentDao.RegistraionNo != null)
                registrationNumberLabel.Text = addStudentDao.RegistraionNo;
            else
                registrationNumberLabel.Text = "Error Occoured!";
        }
    }
}