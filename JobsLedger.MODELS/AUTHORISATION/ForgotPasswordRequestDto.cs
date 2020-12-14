using System.ComponentModel.DataAnnotations;

namespace JobsLedger.MODELS.AUTHORISATION
{
    public class ForgotPasswordRequestDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}