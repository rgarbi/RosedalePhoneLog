using System;
using System.Collections.Generic;

namespace PhoneLog.Models
{
    public partial class UsersOpenAuthData
    {
        public UsersOpenAuthData()
        {
            this.UsersOpenAuthAccounts = new List<UsersOpenAuthAccount>();
        }

        public string ApplicationName { get; set; }
        public string MembershipUserName { get; set; }
        public bool HasLocalPassword { get; set; }
        public virtual ICollection<UsersOpenAuthAccount> UsersOpenAuthAccounts { get; set; }
    }
}
