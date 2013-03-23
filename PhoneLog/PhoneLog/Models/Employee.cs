using System;
using System.Collections.Generic;

namespace PhoneLog.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.PhoneLogs = new List<PhoneLog>();
        }

        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public virtual ICollection<PhoneLog> PhoneLogs { get; set; }
    }
}
