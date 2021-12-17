using System;
using System.Collections.Generic;

namespace Training.Core.Models
{
    public partial class UserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public Guid UserId { get; set; }

        public virtual UserAuth User { get; set; }
    }
}
