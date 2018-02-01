using SimbaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimbaProject.Services;
using SimbaProject.Models;

namespace SimbaProject.Repositories
{
    public class AuthorRepository
    {
        public AuthorRepository(LibraryContext libraryContext)
        {
            LibraryContext = libraryContext;
        }

        public LibraryContext LibraryContext { get; set; }

        public void Add(Author author)
        {
            LibraryContext.Authors.Add(author);
            LibraryContext.SaveChanges();
        }

        public List<Author> GetAuthors()
        {
            return LibraryContext.Authors.ToList();
        }
    }
}
