using System;

namespace JobsLedger.MODELS.AUTHORISATION
{
    public class AccountCreationResponseDto
    {
        public int Id { get; set; }
        public string AccountFirstName { get; set; }
        public string AccountLastName { get; set; }
        public string EmailAddress { get; set; }
        public string Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsVerified { get; set; }

        public string Message { get; set; }
        public bool Success { set; get; }
    }
}