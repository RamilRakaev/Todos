using System.Text.Json;
using Todos.Domain;

namespace Todos.Infrastructure
{
    public class TodoManager
    {
        private readonly List<Todo> todoList;

        private readonly string path = $"{Directory.GetCurrentDirectory()}\\todos.json";

        public TodoManager()
        {
            if (File.Exists(path))
            {
                using (FileStream fs = new(path, FileMode.OpenOrCreate))
                {
                    var savedData = JsonSerializer.Deserialize<List<Todo>>(fs);
                    todoList = new(savedData);
                    fs.Close();
                }
            }
            else
            {
                todoList = new()
                {
                    new() { Title = "todo1" },
                    new() { Title = "todo2" }
                };
                Save();
            }
        }

        public List<Todo> GetTodoList() => todoList;

        public Todo GetTodo(string title) => todoList.First(todo => todo.Title == title);

        public bool Contains(string title)
        {
            return todoList.FirstOrDefault(todo => todo.Title == title) != null;
        }

        public bool AddTodo(string title)
        {
            if (Contains(title) == false)
            {
                todoList.Add(new Todo()
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = title,
                });
                return true;
            }
            return false;
        }

        public bool ChangeTodo(string oldTitle, string newTitle)
        {
            if (Contains(oldTitle))
            {
                GetTodo(oldTitle).Title = newTitle;
                return true;
            }
            return false;
        }

        public void AddTodoToParent(string parentTitle, string title)
        {
            var todo = new Todo()
            {
                ParentId = parentTitle,
                Title = title
            };
            todoList.First(todo => todo.Title == parentTitle).Children.Add(todo);
        }

        public bool Remove(string title)
        {
            if (todoList.Contains(GetTodo(title)))
            {
                todoList.Remove(GetTodo(title));
                return true;
            }
            return false;
        }

        public void DoneTodo(string title)
        {
            todoList.First(todo => todo.Title == title).IsDone = true;
        }

        public void Save()
        {
            using (FileStream fs = new(path, FileMode.Create))
            {
                JsonSerializer.Serialize(fs, todoList);
            }
        }
    }
}