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
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> CallTypeId { get; set; }
        public Nullable<bool> FollowedUp { get; set; }
        public virtual CallType CallType { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
