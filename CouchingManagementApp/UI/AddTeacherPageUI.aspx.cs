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
    public partial class AddTeacherPageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                courseListDdList.Items.Add("--Select--");
                LoadInDDList();
            }
        }

        private void LoadInDDList()
        {
            AllCourseOnDdListDal allcourseList = new AllCourseOnDdListDal();
            DataTable dt = allcourseList.GetAllCourseNameDB();
            if(dt.Rows.Count>0)
            {
                courseListDdList.Items.Clear();
                courseListDdList.Items.Add("--Select--");
                foreach(DataRow dr in dt.Rows)
                {
                    courseListDdList.Items.Add(new ListItem(dr["Course_Name"].ToString(), dr["Course_Name"].ToString()));
                }
            }
            else
            {
                courseListDdList.Items.Clear();
                courseListDdList.Items.Add("--Empty List--");
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(isFormValid())
                {
                    TeacherDetailsEntryDao teacherDetailsEntryDao = new TeacherDetailsEntryDao();
                    teacherDetailsEntryDao.TeacherName = teacherNameTextBox.Text;
                    teacherDetailsEntryDao.Subject = courseListDdList.SelectedValue;
                    teacherDetailsEntryDao.Qualification = qualificationTextBox.Text;

                    IsExistTeacherSubQualificationDal isExist = new IsExistTeacherSubQualificationDal();
                    DataTable dt = isExist.IsExistTeacherSubQualiDB(teacherDetailsEntryDao);
                    if (dt.Rows.Count == 0)
                    {
                        TeacherDetailsEntryDal teacherDetailsEntryDal = new TeacherDetailsEntryDal();
                        string save = teacherDetailsEntryDal.GetInsertTeacherDetailsDB(teacherDetailsEntryDao);
                        if (save != null)
                        {
                            teacherNameTextBox.Text = "";
                            courseListDdList.ClearSelection();
                            qualificationTextBox.Text = "";
                        }
                    }
                    else
                    {
                        Response.Write("This is exist in course!");
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
            if(teacherNameTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Teacher Name Required!");
                teacherNameTextBox.Focus();
                return false;
            }
            if(courseListDdList.Text.Trim()==string.Empty)
            {
                Response.Write("Select Your Course!");
                courseListDdList.Focus();
                return false;
            }
            if(courseListDdList.SelectedIndex==0)
            {
                Response.Write("Select Your Course!");
                courseListDdList.Focus();
                return false;
            }
            if(qualificationTextBox.Text.Trim()==string.Empty)
            {
                Response.Write("Enter Teacher's Qualification!");
                qualificationTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}