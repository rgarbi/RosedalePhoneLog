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
        public string Email { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}