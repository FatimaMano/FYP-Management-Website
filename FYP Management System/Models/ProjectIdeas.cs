using System.ComponentModel.DataAnnotations;

namespace FYP_Management_System.Models
{
    public class ProjectIdeas
    {
        [Key]
        public int Id { get; set; } = 3;

        [Required(ErrorMessage = "Name is required")]
        [StringLength(256)]
        public string name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(256)]
        public string description { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int category { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public int status { get; set; } = 2;
    }
}
