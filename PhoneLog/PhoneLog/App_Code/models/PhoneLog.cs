using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PhoneLog
/// </summary>

namespace PhoneLog.App_Code.models
{
    public class PhoneLog
    {
        public int PhoneLogId { get; set; }
        public string CallerName { get; set; }
        public DateTime CallDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public string MessageTarget { get; set; }
        public string TargetEmail { get; set; }
        public string CallType { get; set; }
        public Boolean FollowedUp { get; set; }

        public int CallTypeId { get; set; }
        public int EmployeeId { get; set; }

        public virtual List<PhoneLog> PhoneLogs { get; set; }
    }
}