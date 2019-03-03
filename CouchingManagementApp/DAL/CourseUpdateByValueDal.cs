using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class CourseUpdateByValueDal
    {
        public string GetCourseUpdatedByvalue(CourseDetailsEntryDao courseDetailsEntryDao)
        {
            string isUpdate = "";
            ConnectionClass connection = new ConnectionClass();
            string query = "update CourseManagement_T set Course_Name='"+courseDetailsEntryDao.CourseName+"', Course_Fee='"+courseDetailsEntryDao.CourseFee+"',Duration='"+courseDetailsEntryDao.Duration+"' where id='"+courseDetailsEntryDao.Id+"'";
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection.GetOpen());
                cmd.ExecuteNonQuery();
                isUpdate = "Update Successful.";
            }
            catch
            {
                isUpdate = "Update Fialed!";
            }
            finally
            {
                connection.GetClose();
            }
            return isUpdate;
        }
    }
}