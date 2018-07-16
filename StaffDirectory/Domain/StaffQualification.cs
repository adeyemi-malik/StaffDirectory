using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public class StaffQualification
    {
        public int StaffId { get; set; }

        public int QualificationId { get; set; }

        public Staff Staff { get; set; }

        public Qualification Qualification { get; set; }
    }
}
