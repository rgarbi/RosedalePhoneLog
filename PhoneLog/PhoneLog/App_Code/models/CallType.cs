using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneLog.App_Code.models
{
    public class CallType
    {
        public int CallId { get; set; }
        public string CallType { get; set; }

        public virtual List<CallType> Calls { get; set; }
    }
}