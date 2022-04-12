namespace Todos.Domain
{
    public class Todo
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public bool IsDone { get; set; }

        public Todo? Parent { get; set; }

        public string ParentId { get; set; }

        public List<Todo> Children { get; set; }
    }
}