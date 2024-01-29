using System.ComponentModel.DataAnnotations;

namespace H3___Secure_Login.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9]*$")]
        public string Username { get; private set; }
        public string Password { get; private set; }
    }
}
