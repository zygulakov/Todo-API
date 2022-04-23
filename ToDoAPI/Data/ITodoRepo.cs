using ToDoAPI.Models;

namespace ToDoAPI.Data
{
    public interface ITodoRepo
    {

        IEnumerable<TodoItem> GetAllTodoItems();

        TodoItem GetTodoItemById(int id);

        TodoItem CreateTodoItem(TodoItem todoItem);

        TodoItem UpdateTodoItem(TodoItem todoItem);

        TodoItem DeleteTodoItem(TodoItem todoItem);

        bool SaveChanges();
    }
}
