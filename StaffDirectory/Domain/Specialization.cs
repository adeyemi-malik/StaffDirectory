using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public class Specialization: BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<StaffSpecialization> Staffs { get; set; }

    }
}
