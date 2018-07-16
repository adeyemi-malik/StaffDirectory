using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public class Staff : BaseEntity
    {
        [Required]
        public string FirstName{get; set;}

        [Required]
        public string LastName { get; set; }

      
        public string OtherName { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
