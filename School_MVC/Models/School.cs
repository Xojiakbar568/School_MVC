using System.ComponentModel.DataAnnotations;

namespace School_MVC.Models
{
    public class School
    {
        [Key,Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Course { get; set; }
    }
}
