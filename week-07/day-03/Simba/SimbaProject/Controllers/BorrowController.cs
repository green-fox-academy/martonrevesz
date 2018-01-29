using Microsoft.AspNetCore.Mvc;
using SimbaProject.Services;
using SimbaProject.Viewmodels;


namespace SimbaProject.Controllers
{
    [Route("borrow")]
    public class BorrowController : Controller
    {
        public BorrowController(BorrowService borrowService)
        {
            BorrowService = borrowService;
        }

        public BorrowService BorrowService { get; set; }
        
        [HttpGet("borrow")]
        public IActionResult Borrow([FromQuery] int bookId)
        {
            ReaderBooksViewModel viewModel = BorrowService.Borrow(bookId);
            return View("mybooks", viewModel);
        }

        [HttpGet("mybooks")]
        public IActionResult MyBooks([FromQuery] int bookId)
        {
            ReaderBooksViewModel viewModel = BorrowService.GetReaderBooks(bookId);
            return View(viewModel);
        }

        [HttpGet("back")]
        public IActionResult Back([FromQuery] int bookId)
        {
            BorrowService.Back(bookId);
            return RedirectToAction("mybooks", bookId);
        }
    }
}
