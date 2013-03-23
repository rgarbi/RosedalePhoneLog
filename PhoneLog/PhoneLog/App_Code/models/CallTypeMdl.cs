using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneLog.App_Code.models
{
    public class CallTypeMdl
    {
        public int CallId { get; set; }
        public string CallType { get; set; }

        public virtual List<CallTypeMdl> Calls { get; set; }
    }
}