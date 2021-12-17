using System;
using System.Collections.Generic;

namespace Training.Core.Models
{
    public partial class UserClaim
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual UserAuth User { get; set; }
    }
}
