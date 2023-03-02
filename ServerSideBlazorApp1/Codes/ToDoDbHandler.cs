using ServerSideBlazorApp1.Models;

namespace ServerSideBlazorApp1.Codes
{
    public class ToDoDbHandler
    {
        public List<ToDo> Read(string user, TodoDbContext context)
        {
            List<ToDo> toDos = context.ToDos.Where(p => p.ToDoUser == user).ToList();

            return toDos;
        }

        public void Insert(string user, string item, string description, TodoDbContext todoDbContext)
        {
            var todoItem = new ToDo()
            {
                ToDoUser = user,
                ToDoItem = item,
                ToDoDescription = description,
            };
            todoDbContext.Entry(todoItem).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            todoDbContext.SaveChanges();
        }

        public void Update(string user, string item, string description, TodoDbContext todoDbContext)
        {
            var todoItem = new ToDo()
            {
                ToDoUser = user,
                ToDoItem = item,
                ToDoDescription = description,
            };
            todoDbContext.Update(todoItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            todoDbContext.SaveChanges();
        }
    }
}
