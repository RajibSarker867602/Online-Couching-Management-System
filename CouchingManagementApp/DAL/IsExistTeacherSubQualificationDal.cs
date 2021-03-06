﻿using System;
using CouchingManagementApp.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAL
{
    public class IsExistTeacherSubQualificationDal
    {
        public DataTable IsExistTeacherSubQualiDB(TeacherDetailsEntryDao teacherDetailsEntryDao)
        {
            DataTable dt = new DataTable();
            ConnectionClass connection = new ConnectionClass();
            string query = "select *from TeacherManagement_T where Teacher_Name='"+teacherDetailsEntryDao.TeacherName+"' and Subject='"+teacherDetailsEntryDao.Subject+"' and Qualification='"+teacherDetailsEntryDao.Qualification+"'";
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