using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public class AcademicStaff: Staff
    {
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<StaffSpecialization> Specializations { get; set; }

        public ICollection<StaffQualification> Qualifications { get; set; }



    }
}
