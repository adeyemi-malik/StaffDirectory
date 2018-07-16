using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public abstract class BaseEntity
    {
        [Required]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [Timestamp, DataType("timestamp")]
        public byte[] Timestamp { get; set; }
    }
}
