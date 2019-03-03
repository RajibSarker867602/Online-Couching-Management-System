using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class TeacherDetailsEntryDal
    {
        public string GetInsertTeacherDetailsDB(TeacherDetailsEntryDao teacherDetailsEntryDao)
        {
            string isSuccess = "";
            ConnectionClass connection = new ConnectionClass();
            string query = "Insert Into TeacherManagement_T values('" + teacherDetailsEntryDao.TeacherName + "','" + teacherDetailsEntryDao.Subject + "','" + teacherDetailsEntryDao.Qualification + "')";
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