using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using JobsLedger.TENANTS.ENTITIES;

namespace JobsLedger.MODELS.AUTHORISATION
{
    public class TenantCreationRequestDto
    {
        [Required]
        public string Database { get; set; }

        [Required]
        public string CompanyName { get; set; }
        public string ABN { get; set; }

        [Required]
        public string CompanyAccountEmail { get; set; }
        
        [Required]
        public string ContactFirstName { get; set; }
        
        [Required]
        public string ContactLastName { get; set; }
        
        [Required]
        public string OfficePhone { get; set; }

        [Required] 
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [Required]
        public int SuburbId { get; set; }

        [Required]
        public string BankName { get; set; }
        [Required]
        public string BankBSB { get; set; }

        [Required] 
        public string BankAccount { get; set; }
    }
}
