using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PhoneLog.App_Code.models;

public class PhoneLogContext : DbContext
{
    public DbSet<PhoneLogMdl> PhoneLogs { get; set; }
    public DbSet<EmployeeMdl> Employees { get; set; }
    public DbSet<CallTypeMdl> CallTypes { get; set; }

}
