using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public TodoContext TodoContext { get; set; }

    }
}
