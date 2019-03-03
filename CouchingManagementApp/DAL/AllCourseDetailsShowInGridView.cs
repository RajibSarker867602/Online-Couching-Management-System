using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class AllCourseDetailsShowInGridView
    {
        public DataTable GetAllCourseDetails()
        {
            DataTable dt = new DataTable();
            ConnectionClass connection = new ConnectionClass();
            string query = "Select *from CourseManagement_T";
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