using System;
using System.Data;
using System.Data.SqlClient;
using CouchingManagementApp.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class StudentSearchByCourseNameDal
    {
        public DataTable GetStudentByCourseName(CourseDetailsEntryDao courseDetailsEntryDao)
        {
            DataTable dt = new DataTable();
            ConnectionClass connection = new ConnectionClass();
            string query = "Select *from StudentManagement_T Where Selected_Course='"+courseDetailsEntryDao.CourseName+"'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, connection.GetOpen());
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                connection.GetClose();
            }
            return dt;
        }
    }
}