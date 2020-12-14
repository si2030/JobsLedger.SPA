using System.ComponentModel.DataAnnotations;
using JobsLedger.TENANTS.ENTITIES;

namespace JobsLedger.MODELS.AUTHORISATION
{
    class CreateNewDataBaseAndTenantAdmin
    {
        public int TenantNo { get; set; }

        [Required]
        public string Database { get; set; }

        [Required]
        public string CompanyName { get; set; }
        public string ABN { get; set; }
        public string CompanyEmail { get; set; }
        public string BankName { get; set; }
        public string BankBSB { get; set; }
        public string BankAccount { get; set; }
        public string OfficePhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }


        public int SuburbId { get; set; }



    }
}
