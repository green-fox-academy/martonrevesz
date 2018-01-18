using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class User
    {
        public int? UserId { get; set; }
        public string Name { get; set; }
        public IList<Todo> Todos { get; set; } = new List<Todo>();
    }
}
