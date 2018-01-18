using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.ViewModels
{
    public class TodoViewModel
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Todo> Todos { get; set; } = new List<Todo>();
    }
}
