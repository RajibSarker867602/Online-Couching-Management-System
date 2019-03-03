using System;
using CouchingManagementApp.DAL;
using CouchingManagementApp.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.BLL
{
    public class StudentRegstraionNoBll
    {
        public string GetStudentRegistraionNo(AddStudentEntryDao addStudentDao)
        {
            addStudentDao.CodeCourse = addStudentDao.SelectedCourse.Substring(0, 2);
            addStudentDao.CodeDate = addStudentDao.Date.Substring(8, 2);
            addStudentDao.RegistraionNo = addStudentDao.CodeCourse + addStudentDao.CodeDate;
            CountStudentSerialDal countStudentSeralDal = new CountStudentSerialDal();
            addStudentDao.RegistraionNo += countStudentSeralDal.GetRegistrationSerialDB(addStudentDao);
            return addStudentDao.RegistraionNo;
        }
    }
}