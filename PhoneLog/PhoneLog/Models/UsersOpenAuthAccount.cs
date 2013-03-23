using System;
using System.Collections.Generic;

namespace PhoneLog.Models
{
    public partial class UsersOpenAuthAccount
    {
        public string ApplicationName { get; set; }
        public string ProviderName { get; set; }
        public string ProviderUserId { get; set; }
        public string ProviderUserName { get; set; }
        public string MembershipUserName { get; set; }
        public Nullable<System.DateTime> LastUsedUtc { get; set; }
        public virtual UsersOpenAuthData UsersOpenAuthData { get; set; }
    }
}
