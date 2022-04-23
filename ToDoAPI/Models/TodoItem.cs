using System;

namespace ToDoAPI.Models
{
	public class TodoItem
	{
		public int Id { get; set; }

		public string Content { get; set; }

		public bool IsCompleted { get; set; }

		public DateTime Date { get; set; }
	}
}