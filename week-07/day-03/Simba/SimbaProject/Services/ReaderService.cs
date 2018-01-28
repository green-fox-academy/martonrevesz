using SimbaProject.Models;
using SimbaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Services
{
    public class ReaderService
    {
        public ReaderService(ReaderRepository readerRepository)
        {
            ReaderRepository = readerRepository;
        }

        public ReaderRepository ReaderRepository { get; set; }

        public List<Reader> GetReaders()
        {
            return ReaderRepository.GetReaders();
        }

        public void Add(Reader reader)
        {
            ReaderRepository.Add(reader);
        }

        public Reader GetSingleReader(int id)
        {
            return ReaderRepository.GetSingleReader(id);
        }

        public void UpdateReader(Reader inputReader, int id)
        {
            ReaderRepository.UpdateReader(inputReader, id);
        }

        public void RemoveReader(int id)
        {
            ReaderRepository.RemoveReader(id);
        }

        public void FineReader(int id)
        {
            ReaderRepository.FineReader(id);
        }
    }
}
