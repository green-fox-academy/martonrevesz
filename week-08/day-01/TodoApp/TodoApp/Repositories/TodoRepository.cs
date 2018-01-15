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

        internal List<Todo> GetActive()
        {
            return TodoContext.Todos.Where(x => x.IsDone == false).ToList();
        }
    }
    }

