using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Repositories;

namespace TodoApp.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        public TodoRepository TodoRepository { get; set; }




        [Route("")]
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
