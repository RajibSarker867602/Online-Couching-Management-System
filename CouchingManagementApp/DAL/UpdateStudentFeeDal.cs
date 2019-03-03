using System;
using System.Data;
using CouchingManagementApp.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CouchingManagementApp.DAL
{
    public class UpdateStudentFeeDal
    {
        public string GetUpdateStudentFeeDB(AddStudentEntryDao addStudentEntryDao)
        {
            string isSuccess = "";
            ConnectionClass connection = new ConnectionClass();
            string query = "Update StudentManagement_T Set Paid_Fee='" + addStudentEntryDao.PaidFee + "',Remaining_Fee='"+addStudentEntryDao.RemainingFee+"' Where Registration_No='"+addStudentEntryDao.RegistraionNo+"'";
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection.GetOpen());
                cmd.ExecuteNonQuery();
                isSuccess = "Upate Successful.";
            }
            catch
            {
                isSuccess = "Update Failed!";
            }
            finally
            {
                connection.GetClose();
            }
            return isSuccess;

        }
    }
}