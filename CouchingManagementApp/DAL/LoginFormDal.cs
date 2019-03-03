using System;
using System.Data;
using System.Data.SqlClient;
using CouchingManagementApp.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class LoginFormDal
    {
        public DataTable GetUserMatchOnDB(RegistrationFormEntryDao registrationFormEntryDao)
        {
            DataTable dt = new DataTable();
            ConnectionClass connection = new ConnectionClass();
            string query = "select *from User_T where User_Name='"+registrationFormEntryDao.UserName+"' and Password='"+registrationFormEntryDao.Password+"'";
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