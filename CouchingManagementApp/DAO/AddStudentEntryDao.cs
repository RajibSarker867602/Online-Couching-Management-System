using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAO
{
    public class AddStudentEntryDao
    {
        public string Id { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
        public string SelectedCourse { get; set; }
        public string SelectedTeacher { get; set; }
        public string RegistraionNo { get; set; }
        public string CodeCourse { get; set; }
        public string CodeDate { get; set; }

        public int CourseFee { get; set; }
        public int PaidFee { get; set; }
        public int RemainingFee { get; set; }
        public int AddFee { get; set; }

        
    }
}