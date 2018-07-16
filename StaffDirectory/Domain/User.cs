using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 256, MinimumLength = 3)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTimeOffset? LockOutEndDate { get; set; }

        public bool LockOutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }


    }
}
