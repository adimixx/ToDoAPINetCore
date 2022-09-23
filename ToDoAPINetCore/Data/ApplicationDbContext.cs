using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoAPINetCore.Models;
using Task = ToDoAPINetCore.Models.Task;

namespace ToDoAPINetCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Group> Group { get; set; } = null!;
        public DbSet<Task> Task { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}