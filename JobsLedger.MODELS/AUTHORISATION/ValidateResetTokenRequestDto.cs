using System.ComponentModel.DataAnnotations;

namespace JobsLedger.MODELS.AUTHORISATION
{
    public class ValidateResetTokenRequestDto
    {
        [Required]
        public string Token { get; set; }
    }
}