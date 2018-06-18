using System.ComponentModel.DataAnnotations;

namespace TriumphRedux.Controllers.Account.Models
{
    public class ForgotPasswordModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
