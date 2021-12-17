using System;
using System.Collections.Generic;

#nullable disable

namespace Training.DAL.Auth
{
    public partial class Role
    {
        public Role()
        {
            RoleClaims = new HashSet<RoleClaim>();
            UserRoles = new HashSet<UserRole>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string CustomRoleProperty { get; set; }

        public virtual ICollection<RoleClaim> RoleClaims { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
