﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Training.DAL.Auth
{
    public partial class UserRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}