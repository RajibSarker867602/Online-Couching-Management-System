using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class RegistrationFormDal
    {
        public string GetInsertOnDB(RegistrationFormEntryDao registrationFormEntryDao)
        {
            string isSuccess = "";
            ConnectionClass connection = new ConnectionClass();
            string query = "Insert Into User_T values('" + registrationFormEntryDao.UserName + "','" + registrationFormEntryDao.Password + "')";
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