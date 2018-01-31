using System;

namespace SimbaProject.Models
{
    public class BookReader
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int ReaderId { get; set; }
        public Reader Reader { get; set; }
        public DateTime BorrowedTime { get; set; } = DateTime.Now;
        public DateTime DueTime { get; set; } = DateTime.Now.AddMinutes(3);
    }
}