using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Models
{
    public class Author
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int Birth { get; set; }
        public string Nationality { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
