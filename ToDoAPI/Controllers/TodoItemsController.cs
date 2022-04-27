using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Dtos;
using ToDoAPI.Models;
using ToDoAPI.Services;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoItemsController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadTodoItemDto>> GetTodoItems()
        {

            return Ok(_todoService.GetAllTodoItems());

        }

        [HttpGet("{id}")]
        public ActionResult<ReadTodoItemDto> GetTodoItemById(int id)
        {
            return Ok(_todoService.GetTodoItemById(id));
        }

        [HttpPatch]
        public ActionResult<ReadTodoItemDto> UpdateTodoItem(UpdateTodoItemDto todoItem)
        {
            return Ok(_todoService.UpdateTodoItem(todoItem));
        }

        [HttpPost]
        public ActionResult<ReadTodoItemDto> CreateTodoItem(CreateTodoItemDto todoItem)
        {
            return Ok(_todoService.CreateTodoItem(todoItem));
        }

        [HttpDelete("{id}")]
        public ActionResult<ReadTodoItemDto> DeleteTodoItemById(int id)
        {
            return Ok(_todoService.DeleteTodoItem(id));
        }
    }
}
