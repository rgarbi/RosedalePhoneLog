using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneLog.Controllers
{
    public class ReportTypes
    {
        public enum types { allLogs=0, thirtyDays=1, notFollowedUp=2 };
    }
}