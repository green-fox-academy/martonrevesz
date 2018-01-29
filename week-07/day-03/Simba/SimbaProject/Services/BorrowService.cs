using SimbaProject.Repositories;
using SimbaProject.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Services
{
    public class BorrowService
    {
        public BorrowService(BorrowRepository borrowRepository,
            ReaderRepository readerRepository,
            BookRepository bookRepository)
        {
            BorrowRepository = borrowRepository;
            ReaderRepository = readerRepository;


        }

        public BorrowRepository BorrowRepository { get; set; }
        public ReaderRepository ReaderRepository { get; set; }
        public BookRepository  BookRepository { get; set; }

        public ReaderBooksViewModel Borrow(int bookId)
        {
            BorrowRepository.Borrow(bookId);
            return GetReaderBooks(bookId);
        }

        public ReaderBooksViewModel GetReaderBooks(int bookId)
        {
            ReaderBooksViewModel viewModel = new ReaderBooksViewModel()
            {
                Reader = ReaderRepository.GetSingleReader(ReaderRepository.CurrentId),
                Books = BorrowRepository.GetBooksForReader(ReaderRepository.CurrentId)

            };
            return viewModel;
        }

        public void Back(int bookId)
        {
            bookId = 4;
            BorrowRepository.Back(bookId);
        }
    }
}
;