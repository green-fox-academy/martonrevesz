using SimbaProject.Entities;
using SimbaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Repositories
{
    public class ReaderRepository
    {
        public static int CurrentId { get; set; } = 3;
        public static double CurrentTemperature;

        public ReaderRepository(LibraryContext libraryContext)
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
            return LibraryContext.Readers.FirstOrDefault(x => x.ReaderId == id);
        }

        public void Add(Reader reader)
        {
            LibraryContext.Readers.Add(reader);
            LibraryContext.SaveChanges();
        }

        public void UpdateReader(Reader inputReader, int id)
        {
            var reader = GetSingleReader(id);
            reader.Name = inputReader.Name;
            reader.Fine = inputReader.Fine;
            reader.UserType = inputReader.UserType;
            reader.VIP = inputReader.VIP;
            LibraryContext.SaveChanges();
        }

        public void RemoveReader(int id)
        {
            var reader = GetSingleReader(id);
            LibraryContext.Remove(reader);
            LibraryContext.SaveChanges();
        }

        public void FineReader(int id)
        {
            var reader = GetSingleReader(id);
            reader.Fine += 10;
            LibraryContext.SaveChanges();
        }


    }
}
