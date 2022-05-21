namespace Todos.Domain
{
    public class Todo
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public bool IsDone { get; set; }

        public TypeTodo Type { get; set; }

        public DateTime TimeToComplete { get; set; }

        public Complexity Complexity { get; set; }

        public Todo? Parent { get; set; }

        public string ParentId { get; set; }

        public List<Todo> Children { get; set; }
    }
}