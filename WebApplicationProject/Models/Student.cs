using System.ComponentModel.DataAnnotations;

namespace WebApplicationProject.Models
{
    public class Student
    {
        [Required(ErrorMessage ="roll no is required")]
        public int RollNo { get; set; }

        [Required(ErrorMessage = "name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = " age is required")]
        [Range(minimum:18,maximum:30,ErrorMessage ="Age must be between 18 to 30")]
        public int Age { get; set; }

        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string Email { get; set; }

        [Required(ErrorMessage = "password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password  is required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password does not match")]
        public string ConfirmPassword { get; set; }


    }
}
