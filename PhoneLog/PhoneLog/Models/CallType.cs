using System;
using System.Collections.Generic;

namespace PhoneLog.Models
{
    public partial class CallType
    {
        public CallType()
        {
            this.PhoneLogs = new List<PhoneLog>();
        }

        public int Id { get; set; }
        public string CallType1 { get; set; }
        public virtual ICollection<PhoneLog> PhoneLogs { get; set; }
    }
}
