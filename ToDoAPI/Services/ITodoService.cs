
using ToDoAPI.Dtos;
using ToDoAPI.Models;

namespace ToDoAPI.Services
{
    public interface ITodoService
    {
        IEnumerable<ReadTodoItemDto> GetAllTodoItems();

        ReadTodoItemDto GetTodoItemById(int id);

        ReadTodoItemDto CreateTodoItem(CreateTodoItemDto todoItem);

        ReadTodoItemDto UpdateTodoItem(UpdateTodoItemDto todoItem);

        ReadTodoItemDto DeleteTodoItem(int id);

    }
}
