using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;
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
        public IActionResult Index([FromQuery] string isActive)
        {
            //var todo = new Todo()
            //{
            //    IsDone = true,
            //    IsUrgent = true,
            //    Title = "New thing to read"
            //};

            //TodoRepository.TodoContext.Todos.Add(todo);
            //TodoRepository.TodoContext.SaveChanges();
            List<Todo> returnList;
            if(isActive == null)
            {
                returnList = TodoRepository.GetAll();
            }
            else if (isActive.Equals("true"))
            {
                returnList = TodoRepository.GetActive();
            }
            else
            {
                returnList = TodoRepository.GetAll();
            }


            return View(returnList);
        }
    }
}
