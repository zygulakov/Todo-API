using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAPI.Dtos
{
    public class UpdateTodoItemDto
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsCompleted { get; set; }
    }
}
