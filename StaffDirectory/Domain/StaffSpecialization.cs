using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public class StaffSpecialization: BaseEntity
    {
        public int StaffId { get; set; }

        public int SpecializationId { get; set; }

        public Staff Staff { get; set; }

        public Specialization Specialization { get; set; }
    }
}
