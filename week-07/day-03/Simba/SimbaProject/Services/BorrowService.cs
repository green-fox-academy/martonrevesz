using SimbaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Services
{
    public class BorrowService
    {
        public BorrowService(BorrowRepository borrowRepository)
        {
            BorrowRepository = borrowRepository;
        }

        public BorrowRepository BorrowRepository { get; set; }

        public void Borrow(int bookId)
        {
            BorrowRepository.Borrow(bookId);
        }
    }
}
