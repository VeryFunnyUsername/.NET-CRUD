using System.ComponentModel.DataAnnotations;

namespace Project_CRUD.Models
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = " Confirm password")]
        [Compare("Password", ErrorMessage = "Entered Passwords don't match")]
        public string ConfirmPassword { get; set; }
    }
}
