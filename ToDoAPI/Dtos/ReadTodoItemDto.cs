using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAPI.Dtos
{
    public class ReadTodoItemDto
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime Date { get; set; }

    }
}
