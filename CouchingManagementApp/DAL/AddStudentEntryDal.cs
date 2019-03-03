using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class AddStudentEntryDal
    {
        public string AddstudentDB(AddStudentEntryDao addStudentEntryDao)
        {
            string isSuccess = "";
            ConnectionClass connection = new ConnectionClass();
            string query = "Insert Into StudentManagement_T (Student_Name,Address,Email,Date,Selected_Course,Course_Fee,Selected_Teacher,Registration_No) values('" + addStudentEntryDao.StudentName + "','" + addStudentEntryDao.Address + "','" + addStudentEntryDao.Email + "','" + addStudentEntryDao.Date + "','" + addStudentEntryDao.SelectedCourse + "','"+addStudentEntryDao.CourseFee+"','" + addStudentEntryDao.SelectedTeacher + "','" + addStudentEntryDao.RegistraionNo + "')";
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection.GetOpen());
                cmd.ExecuteNonQuery();
                isSuccess = "Save Successful.";
            }
            catch
            {
                isSuccess = "Not Saved!";
            }
            finally
            {
                connection.GetClose();
            }
            return isSuccess;
        }
    }
}