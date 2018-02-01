using SimbaProject.Models;
using SimbaProject.Repositories;
using SimbaProject.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Services
{
    public class AuthorService
    {
        public AuthorService(AuthorRepository authorRepository, ReaderRepository readerRepository)
        {
            AuthorRepository = authorRepository;
            ReaderRepository = readerRepository;
        }

        public AuthorRepository AuthorRepository { get; set; }
        public ReaderRepository ReaderRepository { get; set; }

        public void Add(Author author)
        {
            AuthorRepository.Add(author);
        }

        public ReaderAuthorsViewModel GetReaderAuthorsViewModel()
        {
            return new ReaderAuthorsViewModel()
            {
                Reader = ReaderRepository.GetSingleReader(ReaderRepository.CurrentId),
                Authors = AuthorRepository.GetAuthors()
            };
        }
    }
}
