#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using JobsLedger.INTERFACES;

namespace JobsLedger.TENANTS.ENTITIES
{
    public class Account : IEntityBase, IAuditedEntityBase
    {
        public int Id { get; set; }
        public int AccountNo { get; set; }
        public string? AccountName { get; set; }
        public string? Title { get; set; }
        public string? AccountFirstName { get; set; }
        public string? AccountLastName { get; set; }
        public string? MobilePhone { get; set; }
        public string? Email { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }


        public string? PasswordHash { get; set; }
        public bool AcceptTerms { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public string? VerificationToken { get; set; }
        public DateTime? Verified { get; set; }
        public bool IsVerified => Verified.HasValue || PasswordReset.HasValue;
        public string? ResetToken { get; set; }
        public DateTime? ResetTokenExpires { get; set; }
        public DateTime? PasswordReset { get; set; }
        
        public List<RefreshToken>? RefreshTokens { get; set; }

        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }

        // One tenant to many user accounts
        public int TenantId { get; set; }
        public virtual Tenant? Tenant { get; set; }

        // One suburb to many User accounts
        public int SuburbId { get; set; }
    }
}