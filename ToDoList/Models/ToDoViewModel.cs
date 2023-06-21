using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
	public class ToDoViewModel 
	{
		[Key]
		public int? Id { get; set; }

		public string? ToDo { get; set; }

	}
}
