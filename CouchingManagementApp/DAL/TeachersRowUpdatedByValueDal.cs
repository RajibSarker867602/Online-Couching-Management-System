using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class TeachersRowUpdatedByValueDal
    {
        public string GetUpdateTeachersRowByValue(TeacherDetailsEntryDao teacherDetailsEntryDao)
        {
            string isUpdate = "";
            ConnectionClass connection = new ConnectionClass();
            string query = "update TeacherManagement_T set Teacher_Name='" + teacherDetailsEntryDao.TeacherName+ "', Subject='" + teacherDetailsEntryDao.Subject+ "',Qualification='" + teacherDetailsEntryDao.Qualification+ "' where id='" + teacherDetailsEntryDao.Id + "'";
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