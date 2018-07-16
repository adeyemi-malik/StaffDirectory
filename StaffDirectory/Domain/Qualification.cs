using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public class Qualification: BaseEntity
    {
        [Required]
        public string Tiltle { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public ICollection<StaffQualification> Staffs { get; set; }

    }
}
