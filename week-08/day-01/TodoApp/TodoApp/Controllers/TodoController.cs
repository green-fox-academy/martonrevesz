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

        public TodoRepository TodoRepository { get; set; }

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("")]
        [Route("list")]
        public IActionResult Index([FromQuery] bool isActive)
        {
            if (isActive == false)
            {
                return View(TodoRepository.GetAll());
            }
            return View(TodoRepository.GetActive());
        }

        [HttpGet("create")]
        public IActionResult CreateTodo()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult SubmitTodo(Todo todo)
        {
            TodoRepository.Create(todo);
            return RedirectToAction("index");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            TodoRepository.Delete(id);
            return RedirectToAction("index");
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var currentTodo = TodoRepository.TodoContext.Todos.FirstOrDefault(x => x.Id == id);
            return View(currentTodo);
        }

        [HttpPost("edit/{id}")]
        public IActionResult SaveEdit(Todo todo, int id)
        {
            TodoRepository.SaveEdit(todo, id);
            return RedirectToAction("index");
        }
    }
}
