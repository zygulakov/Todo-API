using AutoMapper;
using ToDoAPI.Data;
using ToDoAPI.Dtos;
using ToDoAPI.Models;

namespace ToDoAPI.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepo _repo;
        private readonly IMapper _mapper;

        public TodoService(ITodoRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<ReadTodoItemDto> GetAllTodoItems()
        {
            var todoItems = _repo.GetAllTodoItems();
            return _mapper.Map<IEnumerable<ReadTodoItemDto>>(todoItems);
        }

        public ReadTodoItemDto CreateTodoItem(CreateTodoItemDto todoItemDto)
        {
            var itemToCreate = _mapper.Map<TodoItem>(todoItemDto);
            var newTodoItem = _repo.CreateTodoItem(itemToCreate);
            _repo.SaveChanges();

            return _mapper.Map<ReadTodoItemDto>(newTodoItem);
        }


        public ReadTodoItemDto GetTodoItemById(int id)
        {
            var todoItem = _repo.GetTodoItemById(id);
            if (todoItem is null)
                throw new Exception($"item with id:{id} not found");

            return _mapper.Map<ReadTodoItemDto>(todoItem);
        }

        public ReadTodoItemDto UpdateTodoItem(UpdateTodoItemDto todoItemDto)
        {
            var itemTodUpdate = _mapper.Map<TodoItem>(todoItemDto);
            var updatedTodoItem = _repo.UpdateTodoItem(itemTodUpdate);
            _repo.SaveChanges();
            return _mapper.Map<ReadTodoItemDto>(updatedTodoItem);
        }

        public ReadTodoItemDto DeleteTodoItem(int id)
        {
            var todoItemToRemove = _repo.GetTodoItemById(id);
            if (todoItemToRemove is null)
                throw new Exception($"item with id:{id} not found");

            var deletedItem = _repo.DeleteTodoItem(todoItemToRemove);
            _repo.SaveChanges();
            return _mapper.Map<ReadTodoItemDto>(deletedItem);
        }
    }
}