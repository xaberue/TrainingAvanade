using System;
using System.Collections.Generic;

#nullable disable

namespace Training.DAL.Auth
{
    public partial class UserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
