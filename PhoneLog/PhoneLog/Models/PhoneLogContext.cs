using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PhoneLog.Models.Mapping;

namespace PhoneLog.Models
{
    public partial class PhoneLogContext : DbContext
    {
        static PhoneLogContext()
        {
            Database.SetInitializer<PhoneLogContext>(null);
        }

        public PhoneLogContext()
            : base("Name=PhoneLogContext")
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<CallType> CallTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<PhoneLog> PhoneLogs { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersOpenAuthAccount> UsersOpenAuthAccounts { get; set; }
        public DbSet<UsersOpenAuthData> UsersOpenAuthDatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApplicationMap());
            modelBuilder.Configurations.Add(new CallTypeMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new MembershipMap());
            modelBuilder.Configurations.Add(new PhoneLogMap());
            modelBuilder.Configurations.Add(new ProfileMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UsersOpenAuthAccountMap());
            modelBuilder.Configurations.Add(new UsersOpenAuthDataMap());
        }
    }
}
