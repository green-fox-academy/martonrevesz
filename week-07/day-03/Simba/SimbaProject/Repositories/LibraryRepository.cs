using SimbaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Repositories
{
    public class LibraryRepository
    {
        public LibraryRepository(LibraryContext libraryContext)
        {
            LibraryContext = libraryContext;
        }

        public LibraryContext LibraryContext { get; set; }
    }
}
