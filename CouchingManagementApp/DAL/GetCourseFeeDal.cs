using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class GetCourseFeeDal
    {
        public DataTable GetCourseFee(TeacherDetailsEntryDao teacherDetailsDao)
        {
            DataTable dt = new DataTable();
            ConnectionClass connection = new ConnectionClass();
            string query = "Select *from CourseManagement_T Where Course_Name='" + teacherDetailsDao.Subject + "'";
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