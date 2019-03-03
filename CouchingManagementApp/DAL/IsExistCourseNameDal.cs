using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class IsExistCourseNameDal
    {
        public DataTable IsExistCourseNameInDB(CourseDetailsEntryDao courseDetailsEntryDao)
        {
            DataTable dt = new DataTable();
            ConnectionClass connection = new ConnectionClass();
            string qurery = "select *from CourseManagement_T where Course_Name='" + courseDetailsEntryDao.CourseName + "'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qurery, connection.GetOpen());
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