using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Name can`t be empty")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Digits and characters are not allowed.")]
        public string Name { get; set; }
        
    }
}
