using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public ICollection<BookReader> BookReaders { get; set; }
        public int TotalCopies { get; set; }
        public int BorrowedCopies { get; set; }
    }
}
