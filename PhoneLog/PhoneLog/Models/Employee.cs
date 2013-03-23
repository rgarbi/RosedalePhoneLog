using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneLog.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.PhoneLogs = new List<PhoneLog>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public virtual ICollection<PhoneLog> PhoneLogs { get; set; }
    }
}
