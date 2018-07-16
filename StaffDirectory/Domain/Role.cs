using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public class Role : BaseEntity
    {

        [Required]
        [StringLength(maximumLength: 256, MinimumLength = 3)]
        public string Name { get; set; }

        public virtual ICollection<UserRole> RoleUsers { get; set; }

    }
}
