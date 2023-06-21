using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models

{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-9J1C0DI\\SQLEXPRESS; database=ToDoList; integrated security=true;TrustServerCertificate=True");
		}

		public DbSet<ToDoViewModel> ToDo { get; set; }
	}
}
