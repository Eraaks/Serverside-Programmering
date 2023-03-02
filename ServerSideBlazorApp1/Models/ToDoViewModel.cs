namespace ServerSideBlazorApp1.Models
{
    public class ToDoViewModel
    {
        public int ToDoUserId { get; set; }

        public string ToDoUser { get; set; } = null!;

        public string ToDoItem { get; set; } = null!;

        public string? ToDoDescription { get; set; }
    }
}
