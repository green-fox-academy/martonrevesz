using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimbaProject.Models;
using SimbaProject.Repositories;
using SimbaProject.Services;
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
            bookId = 3;
            BorrowService.Borrow(bookId);
            return Ok();
        }

        [HttpGet("back")]
        public IActionResult Back([FromQuery] int bookId)
        {
            bookId = 3;

            BorrowService.Back(bookId);
            return Ok();
        }
    }
}
