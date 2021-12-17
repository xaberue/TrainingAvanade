using System;
using System.Collections.Generic;

namespace Training.Core.Models
{
    public partial class UserRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual UserAuth User { get; set; }
    }
}
