

using ToDoAPI.Models;

namespace ToDoAPI.Data
{
    public class InMemoryRepo : ITodoRepo
    {
        private readonly AppDbContext _context;

        public InMemoryRepo(AppDbContext context)
        {
            _context = context;
        }

        public TodoItem CreateTodoItem(TodoItem todoItem)
        {
            if (todoItem == null)
                throw new ArgumentNullException(nameof(todoItem));

            return _context.TodoItems.Add(todoItem).Entity;
        }

        public IEnumerable<TodoItem> GetAllTodoItems()
        {
            return _context.TodoItems.ToList();
        }

        public TodoItem GetTodoItemById(int id)
        {
            return _context.TodoItems.FirstOrDefault(t => t.Id == id);
        }

        public TodoItem UpdateTodoItem(TodoItem todoItem)
        {
            return _context.TodoItems.Update(todoItem).Entity;
        }

        public TodoItem DeleteTodoItem(TodoItem todoItem)
        {
            return _context.TodoItems.Remove(todoItem).Entity;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
