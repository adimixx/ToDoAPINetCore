using System.ComponentModel.DataAnnotations;

namespace ToDoAPINetCore.Models
{
    public class Group
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<Task> Tasks { get; set; } = null!;

    }
}
