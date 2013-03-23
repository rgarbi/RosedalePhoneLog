using System;
using System.Collections.Generic;

namespace PhoneLog.Models
{
    public partial class PhoneLog
    {
        public int Id { get; set; }
        public string CallerName { get; set; }
        public Nullable<System.DateTime> CallDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public Nullable<bool> FollowedUp { get; set; }
        public string EmployeeEmail { get; set; }
        public string CallType { get; set; }
    }
}
