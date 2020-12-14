using System.ComponentModel.DataAnnotations;

namespace JobsLedger.MODELS.AUTHORISATION
{
    public class VerifyEmailRequestDto
    {
        [Required]
        public string Token { get; set; }
    }
}