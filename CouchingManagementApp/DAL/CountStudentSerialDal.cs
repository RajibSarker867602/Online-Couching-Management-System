using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class CountStudentSerialDal
    {
        public string GetRegistrationSerialDB(AddStudentEntryDao addStudentEntryDao)
        {
            int cnt = 0;
            string totalCnt = "";
            ConnectionClass connection = new ConnectionClass();
            string query = "select Count(*) cnt from StudentManagement_T where Selected_Course='" + addStudentEntryDao.SelectedCourse + "' and Selected_Teacher='" + addStudentEntryDao.SelectedTeacher + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection.GetOpen());
                int temp =(int) cmd.ExecuteScalar();
                cnt = temp+1;
                if (cnt <= 15)
                {
                    totalCnt = cnt.ToString();
                    if (totalCnt.Length <= 1)
                        totalCnt = "0" + totalCnt;
                }
                else
                    totalCnt = "Maximux Number Of Student";
            }
            catch
            {
                totalCnt = "";
            }
            finally
            {
                connection.GetClose();
            }
            return totalCnt;
        }
    }
}