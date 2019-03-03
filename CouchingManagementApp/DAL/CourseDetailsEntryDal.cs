using System;
using CouchingManagementApp.DAO;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class CourseDetailsEntryDal
    {
        public string GetInsertInDb(CourseDetailsEntryDao courseDetailsEntryDao)
        {
            string isSuccess = "";
            ConnectionClass connection = new ConnectionClass();
            string query = "Insert Into CourseManagement_T values('" + courseDetailsEntryDao.CourseName + "','" + courseDetailsEntryDao.CourseFee + "','" + courseDetailsEntryDao.Duration + "')";
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection.GetOpen());
                cmd.ExecuteNonQuery();
                isSuccess = "Save Success.";
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