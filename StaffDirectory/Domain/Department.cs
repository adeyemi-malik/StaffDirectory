using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public class Department: BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int CollegeId { get; set; }

        public College College { get; set; }

    }
}
