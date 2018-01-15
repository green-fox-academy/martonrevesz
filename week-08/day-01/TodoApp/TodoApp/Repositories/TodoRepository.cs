using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;
using TodoApp.Models;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        public TodoContext TodoContext { get; set; }

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public List<Todo> GetAll()
        {
            return TodoContext.Todos.ToList();
        }

        public List<Todo> GetActive()
        {
            return TodoContext.Todos.Where(x => x.IsDone == false).ToList();
        }

        public void Create(Todo todo)
        {

            TodoContext.Todos.Add(todo);
            TodoContext.SaveChanges();  
        }

        public void Delete(int id)
        {
            var todo = TodoContext.Todos.FirstOrDefault(x => x.Id == id);
            if (todo != null)
            {
                TodoContext.Todos.Remove(todo);
            }            
            TodoContext.SaveChanges();
        }
    }
}

