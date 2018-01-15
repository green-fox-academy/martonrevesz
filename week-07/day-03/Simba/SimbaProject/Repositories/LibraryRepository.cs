using SimbaProject.Entities;
using SimbaProject.Models;
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

        public List<Reader> GetReaders()
        {
            return LibraryContext.Readers.ToList();
        }

        public Reader GetSingleReader(int id)
        {
            return LibraryContext.Readers.FirstOrDefault(x => x.Id == id);
        }
    }
}
