using SimbaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Viewmodels
{
    public class ReaderAuthorsViewModel
    {
        public Reader Reader { get; set; }
        public List<Author> Authors { get; set; }
    }
}
