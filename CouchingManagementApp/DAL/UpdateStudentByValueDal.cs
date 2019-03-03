using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class UpdateStudentByValueDal
    {
        public string GetUpdateStudentByValue(AddStudentEntryDao addStudentEntryDao)
        {
            string isUpdate = "";
            ConnectionClass connection = new ConnectionClass();
            string query = "update StudentManagement_T set Student_Name='" + addStudentEntryDao.StudentName+ "', Address='" + addStudentEntryDao.Address+ "',Email='" + addStudentEntryDao.Email+ "' where id='" + addStudentEntryDao.Id+ "'";
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