using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;
using TodoApp.Models;
using TodoApp.ViewModels;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        public TodoRepository(TodoContext todoContext, TodoViewModel todoViewModel)
        {
            TodoContext = todoContext;
            TodoViewModel = todoViewModel;
        }

        public TodoContext TodoContext { get; set; }
        public TodoViewModel TodoViewModel { get; set; }


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
            var todo = TodoContext.Todos.FirstOrDefault(x => x.TodoId == id);
            if (todo != null)
            {
                TodoContext.Todos.Remove(todo);
            }            
            TodoContext.SaveChanges();
        }

        public User GetUser(string name)
        {
            return TodoContext.Users.FirstOrDefault(x => x.Name == name);
        }

        public TodoViewModel GetViewModel()
        {
            TodoViewModel.Todos = TodoContext.Todos.ToList();
            TodoViewModel.Users = TodoContext.Users.ToList();
            return TodoViewModel;
        }

        public void SaveEdit(Todo todo, int id)
        {
            var todoToUpdate = TodoContext.Todos.FirstOrDefault(x => x.TodoId == id);
            todoToUpdate.Title = todo.Title;
            todoToUpdate.IsDone = todo.IsDone;
            todoToUpdate.IsUrgent= todo.IsUrgent;
            TodoContext.SaveChanges();
        }

        public void CreateUser(User user)
        {
            TodoContext.Users.Add(user);
            TodoContext.SaveChanges();
        }

        public void DeleteUser(string name)
        {
            User usertoDelete = TodoContext.Users.First(x => x.Name.Equals(name));
            TodoContext.Users.Remove(usertoDelete);
            TodoContext.SaveChanges();
        }
    }
}

