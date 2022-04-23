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
            try
            {

                return Ok(_todoService.GetAllTodoItems());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ReadTodoItemDto> GetTodoItemById(int id)
        {
            try
            {
                return Ok(_todoService.GetTodoItemById(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPatch]
        public ActionResult<ReadTodoItemDto> UpdateTodoItem(UpdateTodoItemDto todoItem)
        {
            try
            {
                return Ok(_todoService.UpdateTodoItem(todoItem));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<ReadTodoItemDto> CreateTodoItem(CreateTodoItemDto todoItem)
        {
            try
            {
                return Ok(_todoService.CreateTodoItem(todoItem));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<ReadTodoItemDto> DeleteTodoItemById(int id)
        {
            try
            {
                return Ok(_todoService.DeleteTodoItem(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
