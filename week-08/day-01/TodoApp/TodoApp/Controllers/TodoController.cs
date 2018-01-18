using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;
using TodoApp.Repositories;

namespace TodoApp.Controllers
{
    [Route("")]
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
            return View(TodoRepository.GetViewModel());
        }

        [HttpGet("create")]
        public IActionResult CreateTodo()
        {
            return View(TodoRepository.GetViewModel());
        }

        [HttpPost("create")]
        public IActionResult SubmitTodo(Todo todo, string User)
        {
            todo.User = TodoRepository.GetUser(User);
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
            var currentTodo = TodoRepository.TodoContext.Todos.FirstOrDefault(x => x.TodoId == id);
            return View(currentTodo);
        }

        [HttpPost("edit/{id}")]
        public IActionResult SaveEdit(Todo todo, int id)
        {
            TodoRepository.SaveEdit(todo, id);
            return RedirectToAction("index");
        }

        [HttpGet("user")]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost("user")]
        public IActionResult SaveUser(User user)
        {
            TodoRepository.CreateUser(user);
            return RedirectToAction("index");
        }

        [HttpGet("deleteuser")]
        public IActionResult DeleteUser()
        {
            return View(TodoRepository.GetViewModel());
        }

        [HttpPost("deleteuser")]
        public IActionResult Delete(string name)
        {
            TodoRepository.DeleteUser(name);
            return RedirectToAction("index");
        }
    }
}
