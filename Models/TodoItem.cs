using System.ComponentModel.DataAnnotations;

namespace CoreSQLiteDemo.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public bool IsDone { get; set; }
    }
}
