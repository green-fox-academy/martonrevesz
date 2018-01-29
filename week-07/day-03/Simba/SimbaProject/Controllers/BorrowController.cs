using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimbaProject.Models;
using SimbaProject.Repositories;
using SimbaProject.Services;
using SimbaProject.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return Ok();
        }
    }
}
