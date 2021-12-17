using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Contracts;

namespace Training.Core.Models
{
    public class Album : IRemovable
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public Album()
        {
            Reservations = Enumerable.Empty<Reservation>().ToList();
        }
    }
}
