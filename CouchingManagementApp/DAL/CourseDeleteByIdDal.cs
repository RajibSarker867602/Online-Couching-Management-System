using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class CourseDeleteByIdDal
    {
        public string GetDeleteById(CourseDetailsEntryDao courseDetailsEntryDao)
        {
            string isDelete = "";
            ConnectionClass connection = new ConnectionClass();
            string query = "delete from CourseManagement_T where id=" + courseDetailsEntryDao.Id + "";
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection.GetOpen());
                cmd.ExecuteNonQuery();
                isDelete = "Delete Successful.";
            }
            catch(Exception r)
            {
                isDelete = "Delete Failed!";
            }
            finally
            {
                connection.GetClose();
            }
            return isDelete;
        }
    }
}