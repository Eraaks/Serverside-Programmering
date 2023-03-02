using System;
using System.Collections.Generic;

namespace ServerSideBlazorApp1.Models;

public partial class ToDo
{
    public int ToDoUserId { get; set; }

    public string ToDoUser { get; set; } = null!;

    public string ToDoItem { get; set; } = null!;

    public string? ToDoDescription { get; set; }
}
