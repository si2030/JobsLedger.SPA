using System.ComponentModel.DataAnnotations;

namespace JobsLedger.MODELS.AUTHORISATION
{
    public class AuthenticateRequestDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}