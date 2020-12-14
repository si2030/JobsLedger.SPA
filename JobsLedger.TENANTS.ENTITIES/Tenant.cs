using System.Collections.Generic;
using System.Threading.Tasks;
using JobsLedger.INTERFACES;

namespace JobsLedger.TENANTS.ENTITIES
{
    public class Tenant : IEntityBase, IAuditedEntityBase
    {
        public Tenant()
        {
            
        }
        public int Id { get; set; }
        public int TenantNo { get; set; }
        public string Database { get; set; }
        public string CompanyName { get; set; }
        public string ABN { get; set; }
        public string CompanyAccountEmail { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string OfficePhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string BankName { get; set; }
        public string BankBSB { get; set; }
        public string BankAccount { get; set; }

        public int SuburbId { get; set; }



    }
}