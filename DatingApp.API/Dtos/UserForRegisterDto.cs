using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "You must specify the username between 4 and 10 characters")]
        public string Username { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "You must specify the username between 8 and 15 characters")]
        public string Password { get; set; }
    }
}