using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneLog.App_Code.models
{
    public class Employee
    {
        public int EpmployeeId { get; set; }
        public string EmployeeName { get; set; }
        private string _email;
    }
}