using SimbaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Viewmodels
{
    public class ReaderBooksViewModel
    {
        public IList<Book> Books { get; set; }
        public Reader Reader { get; set; }
    }
}
