using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PhoneLog.Models.Mapping
{
    public class UsersOpenAuthDataMap : EntityTypeConfiguration<UsersOpenAuthData>
    {
        public UsersOpenAuthDataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ApplicationName, t.MembershipUserName });

            // Properties
            this.Property(t => t.ApplicationName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.MembershipUserName)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("UsersOpenAuthData");
            this.Property(t => t.ApplicationName).HasColumnName("ApplicationName");
            this.Property(t => t.MembershipUserName).HasColumnName("MembershipUserName");
            this.Property(t => t.HasLocalPassword).HasColumnName("HasLocalPassword");
        }
    }
}
