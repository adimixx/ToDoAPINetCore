using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoAPINetCore.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        public string ?Description { get; set; }

        public Group Group { get; set; } = null!;
    }
}
