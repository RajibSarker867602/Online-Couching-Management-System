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
    public partial class StudentPageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadInSubjectDdList();
                studentListDdList.Items.Add("--Empty List--");
            }
        }

        protected void subjectDdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseDetailsEntryDao courseDetailsEntryDao = new CourseDetailsEntryDao();
            courseDetailsEntryDao.CourseName = subjectDdList.SelectedValue;

            StudentSearchByCourseNameDal studentSearchByCourseNameDal = new StudentSearchByCourseNameDal();
            DataTable dt = studentSearchByCourseNameDal.GetStudentByCourseName(courseDetailsEntryDao);

            if(dt.Rows.Count>0)
            {
                studentListDdList.Items.Clear();
                studentListDdList.Items.Add("--Select--");
                foreach(DataRow dr in dt.Rows)
                {
                    studentListDdList.Items.Add(new ListItem(dr["Student_Name"].ToString(), dr["Registration_No"].ToString()));
                }
            }
            else
            {
                studentListDdList.Items.Clear();
                studentListDdList.Items.Add("--Empty List--");
            }
        }
        public void LoadInSubjectDdList()
        {
            AllCourseOnDdListDal allCourseOnDdListDal = new AllCourseOnDdListDal();
            DataTable dt = allCourseOnDdListDal.GetAllCourseNameDB();
            if (dt.Rows.Count > 0)
            {
                subjectDdList.Items.Clear();
                subjectDdList.Items.Add("--Select--");
                foreach (DataRow dr in dt.Rows)
                {
                    subjectDdList.Items.Add(new ListItem(dr["Course_Name"].ToString(), dr["Course_Name"].ToString()));
                }
            }
            else
            {
                subjectDdList.Items.Clear();
                subjectDdList.Items.Add("--Empty List--");
            }
        }
    }
}