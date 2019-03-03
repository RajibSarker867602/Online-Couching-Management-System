using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAO
{
    public class CourseDetailsEntryDao
    {
        public string Id { get; set; }
        public string CourseName { get; set; }
        public int CourseFee { get; set; }
        public string Duration { get; set; }
    }
}