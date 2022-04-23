using AutoMapper;
using ToDoAPI.Dtos;
using ToDoAPI.Models;

namespace ToDoAPI.Profiles
{
    public class TodoItemsProfile : Profile
    {
        public TodoItemsProfile()
        {
            CreateMap<CreateTodoItemDto, TodoItem>().BeforeMap((s, d) => d.Date = DateTime.Now);
            CreateMap<TodoItem, UpdateTodoItemDto>();
            CreateMap<UpdateTodoItemDto, TodoItem>().BeforeMap((s, d) => d.Date = DateTime.Now);
            CreateMap<TodoItem, ReadTodoItemDto>();
        }
    }
}
