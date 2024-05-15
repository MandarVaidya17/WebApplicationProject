using System.ComponentModel.DataAnnotations;

namespace WebApplicationProject.Models
{
    public class Book
    {
        [Required(ErrorMessage ="id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "author name is required")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage ="price is required")]
        [Range(minimum:1,maximum:1000)]
        public int Price {  get; set; }
    }
}
