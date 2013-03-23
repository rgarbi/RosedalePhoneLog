using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PhoneLog.Models.Mapping
{
    public class CallTypeMap : EntityTypeConfiguration<CallType>
    {
        public CallTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CallType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CallType1).HasColumnName("CallType");
        }
    }
}
