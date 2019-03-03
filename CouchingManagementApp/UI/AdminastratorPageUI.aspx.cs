using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouchingManagementApp.DAO;
using CouchingManagementApp.DAL;
using System.Data;
using System.Data.SqlClient;

namespace CouchingManagementApp.UI
{
    public partial class AdminastratorPageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                registrationNoTextBox.Visible = false;
                registrationNoLabel.Visible = false;    
            }
        }

        protected void modifyDdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(modifyDdList.SelectedItem.Text=="Course")
            {
                LoadGrid();
                allCourseListGrid.Visible = true;
                allTeacherListGridView.Visible = false;
                registrationNoLabel.Visible = false;
                registrationNoTextBox.Visible = false;
                studentRecordsGridView.Visible = false;
            }
            if (modifyDdList.SelectedItem.Text == "Teacher's")
            {
                LoadInTeacherGrid();
                allTeacherListGridView.Visible = true;
                allCourseListGrid.Visible = false;
                registrationNoLabel.Visible = false;
                registrationNoTextBox.Visible = false;
                studentRecordsGridView.Visible = false;
            }
            if(modifyDdList.SelectedItem.Text=="Student")
            {
                registrationNoLabel.Visible = true;
                registrationNoTextBox.Visible = true;
                allCourseListGrid.Visible = false;
                allTeacherListGridView.Visible = false;
                registrationNoTextBox.Text = "";
            }
        }

        private void LoadInTeacherGrid()
        {
            AllTeacherDetailsShowInGrid allTeachersDetailsShowInGrid = new AllTeacherDetailsShowInGrid();
            DataTable dt = allTeachersDetailsShowInGrid.ShowAllTeacherDetailsInGrid();
            allTeacherListGridView.DataSource = dt;
            allTeacherListGridView.DataBind();
        }

        protected void allCourseListGrid_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            CourseDetailsEntryDao courseDetailsEntrDao = new CourseDetailsEntryDao();
            int index = e.RowIndex;
            courseDetailsEntrDao.Id = ((Label)(allCourseListGrid.Rows[index].FindControl("idLabel"))).Text;

            CourseDeleteByIdDal courseDeleteByIdDal = new CourseDeleteByIdDal();
            string delete = courseDeleteByIdDal.GetDeleteById(courseDetailsEntrDao);
            if (delete != null)
                LoadGrid();
        }

        protected void allCourseListGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int index = e.NewEditIndex;
            allCourseListGrid.EditIndex = index;
            LoadGrid();
        }

        protected void allCourseListGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            allCourseListGrid.EditIndex = -1;
            LoadGrid();
        }
        public void LoadGrid()
        {
            AllCourseDetailsShowInGridView allCourseDetailsShowInGrid = new AllCourseDetailsShowInGridView();
            DataTable dt = allCourseDetailsShowInGrid.GetAllCourseDetails();
            allCourseListGrid.DataSource = dt;
            allCourseListGrid.DataBind();
        }

        protected void allCourseListGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            CourseDetailsEntryDao courseDetailsEntryDao = new CourseDetailsEntryDao();
            int index = e.RowIndex;
            courseDetailsEntryDao.Id = ((Label)(allCourseListGrid.Rows[index].FindControl("idLabel"))).Text;
            courseDetailsEntryDao.CourseName = ((TextBox)(allCourseListGrid.Rows[index].FindControl("courseNameTextBox"))).Text;
            courseDetailsEntryDao.CourseFee =Convert.ToInt32(((TextBox)(allCourseListGrid.Rows[index].FindControl("courseFeeTextBox"))).Text);
            courseDetailsEntryDao.Duration = ((TextBox)(allCourseListGrid.Rows[index].FindControl("durationTextBox"))).Text;

            CourseUpdateByValueDal courseUpdateByValueDal = new CourseUpdateByValueDal();
            string update = courseUpdateByValueDal.GetCourseUpdatedByvalue(courseDetailsEntryDao);
            if(update!=null)
            {
                allCourseListGrid.EditIndex = -1;
                LoadGrid();
            }
        }

        protected void allTeacherListGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TeacherDetailsEntryDao teacherDetailsEntryDao = new TeacherDetailsEntryDao();
            int index = e.RowIndex;
            teacherDetailsEntryDao.Id = ((Label)(allTeacherListGridView.Rows[index].FindControl("tIdLabel"))).Text;

            TeacherRowDeletedByIdDal teacherRowDeleteByIdDal = new TeacherRowDeletedByIdDal();
            string delete = teacherRowDeleteByIdDal.GetDeleteTeacherRowById(teacherDetailsEntryDao);
            if(delete!=null)
            {
                LoadInTeacherGrid();
            }
        }

        protected void allTeacherListGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            allTeacherListGridView.EditIndex = -1;
            LoadInTeacherGrid();
        }

        protected void allTeacherListGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TeacherDetailsEntryDao teacherDetailsEntryDao = new TeacherDetailsEntryDao();
            int index = e.RowIndex;
            teacherDetailsEntryDao.Id = ((Label)(allTeacherListGridView.Rows[index].FindControl("tIdLabel"))).Text;
            teacherDetailsEntryDao.TeacherName = ((TextBox)(allTeacherListGridView.Rows[index].FindControl("teacherNameTextBox"))).Text;
            teacherDetailsEntryDao.Subject = ((TextBox)(allTeacherListGridView.Rows[index].FindControl("subjectTextBox"))).Text;
            teacherDetailsEntryDao.Qualification = ((TextBox)(allTeacherListGridView.Rows[index].FindControl("qualificationTextBox"))).Text;

            TeachersRowUpdatedByValueDal teacherRowsUpdatedByValueDal = new TeachersRowUpdatedByValueDal();
            string update = teacherRowsUpdatedByValueDal.GetUpdateTeachersRowByValue(teacherDetailsEntryDao);
            if(update!=null)
            {
                allTeacherListGridView.EditIndex = -1;
                LoadInTeacherGrid();
            }
        }

        protected void allTeacherListGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int index = e.NewEditIndex;
            allTeacherListGridView.EditIndex = index;
            LoadInTeacherGrid();
        }

        protected void studentRecordsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            AddStudentEntryDao addStudentEntryDao = new AddStudentEntryDao();
            int index = e.RowIndex;
            addStudentEntryDao.Id = ((Label)(studentRecordsGridView.Rows[index].FindControl("sIdLabel"))).Text;

            StudentDeletedByIdDal studentDeletedByIdDal = new StudentDeletedByIdDal();
            string delete = studentDeletedByIdDal.GetStudentDeleteById(addStudentEntryDao);
            if(delete!=null)
            {
                LoadInStudentRecordGrid();
            }
        }

        protected void registrationNoTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadInStudentRecordGrid();
        }
        public void LoadInStudentRecordGrid()
        {
            AddStudentEntryDao addStudentEntryDao = new AddStudentEntryDao();
            addStudentEntryDao.RegistraionNo = registrationNoTextBox.Text;

            SearchStudentByRegistrationNoDal searchStudentByRegistrationNoDal = new SearchStudentByRegistrationNoDal();
            DataTable searchStudent = searchStudentByRegistrationNoDal.StudentSearchByRegistrationNoDB(addStudentEntryDao);
            if (searchStudent.Rows.Count > 0)
            {
                studentRecordsGridView.Visible = true;
                studentRecordsGridView.DataSource = searchStudent;
                studentRecordsGridView.DataBind();
            }
            else
            {
                Response.Write("No Student Record Found!");
                studentRecordsGridView.Visible = false;
            }
        }

        protected void studentRecordsGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int index = e.NewEditIndex;
            studentRecordsGridView.EditIndex = index;
            LoadInStudentRecordGrid();
        }

        protected void studentRecordsGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            studentRecordsGridView.EditIndex = -1;
            LoadInStudentRecordGrid();
        }

        protected void studentRecordsGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            AddStudentEntryDao addStudentEntryDao = new AddStudentEntryDao();
            int index = e.RowIndex;
            addStudentEntryDao.Id = ((Label)(studentRecordsGridView.Rows[index].FindControl("sIdLabel"))).Text;
            addStudentEntryDao.StudentName = ((TextBox)(studentRecordsGridView.Rows[index].FindControl("studentNameTextBox"))).Text;
            addStudentEntryDao.Address = ((TextBox)(studentRecordsGridView.Rows[index].FindControl("addressTextBox"))).Text;
            addStudentEntryDao.Email = ((TextBox)(studentRecordsGridView.Rows[index].FindControl("emailTextBox"))).Text;

            UpdateStudentByValueDal updateStudentByValueDal = new UpdateStudentByValueDal();
            string update = updateStudentByValueDal.GetUpdateStudentByValue(addStudentEntryDao);
            if(update!=null)
            {
                studentRecordsGridView.EditIndex = -1;
                LoadInStudentRecordGrid();
            }
        }
    }
}