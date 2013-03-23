using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneLog.Models
{
    public partial class CallType
    {
        public CallType()
        {
            this.PhoneLogs = new List<PhoneLog>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CallType1 { get; set; }
        public virtual ICollection<PhoneLog> PhoneLogs { get; set; }
    }
}
