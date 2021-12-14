using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
