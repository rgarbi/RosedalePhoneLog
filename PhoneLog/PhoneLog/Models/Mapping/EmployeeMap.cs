using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PhoneLog.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.EmployeeEmail);
                

            // Table & Column Mappings
            this.ToTable("Employee");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmployeeName).HasColumnName("EmployeeName");
            this.Property(t => t.EmployeeEmail).HasColumnName("EmployeeEmail");
        }
    }
}
