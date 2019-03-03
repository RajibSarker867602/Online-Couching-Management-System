using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class ConnectionClass
    {
        SqlConnection con;
        public SqlConnection GetOpen()
        {
            string conStr = ConfigurationManager.ConnectionStrings["couchingManagementAppConStr"].ToString();
            con = new SqlConnection(conStr);
            con.Open();
            return con;
        }
        public void GetClose()
        {
            if (con != null)
                con.Close();
        }
    }
}