using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PhoneLog.Models.Mapping
{
    public class PhoneLogMap : EntityTypeConfiguration<PhoneLog>
    {
        public PhoneLogMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PhoneLog");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CallerName).HasColumnName("CallerName");
            this.Property(t => t.CallDate).HasColumnName("CallDate");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.CallTypeId).HasColumnName("CallTypeId");
            this.Property(t => t.FollowedUp).HasColumnName("FollowedUp");

            // Relationships
            this.HasOptional(t => t.CallType)
                .WithMany(t => t.PhoneLogs)
                .HasForeignKey(d => d.CallTypeId);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.PhoneLogs)
                .HasForeignKey(d => d.EmployeeId);

        }
    }
}
