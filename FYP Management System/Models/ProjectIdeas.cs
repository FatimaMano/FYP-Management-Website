using System.ComponentModel.DataAnnotations;

namespace FYP_Management_System.Models
{
    public class ProjectIdeas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public int category { get; set; }
        [Required]
        public int status { get; set; }
    }
}
