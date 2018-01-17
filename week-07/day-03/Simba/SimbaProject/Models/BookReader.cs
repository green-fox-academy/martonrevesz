namespace SimbaProject.Models
{
    public class BookReader
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int ReaderId { get; set; }
        public Reader Reader { get; set; }
    }
}