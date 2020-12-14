using System.ComponentModel.DataAnnotations;
using JobsLedger.TENANTS.ENTITIES;

namespace JobsLedger.MODELS.AUTHORISATION
{
    public class AccountCreationRequestDto
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Range(typeof(bool), "true", "true")]
        public bool AcceptTerms { get; set; }
    }
}