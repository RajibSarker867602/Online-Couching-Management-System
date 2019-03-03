using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchingManagementApp.DAO
{
    public class RegistrationFormEntryDao
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}