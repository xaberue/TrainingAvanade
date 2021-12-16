using System;

namespace Training.Core.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string NationalIdentifier { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
