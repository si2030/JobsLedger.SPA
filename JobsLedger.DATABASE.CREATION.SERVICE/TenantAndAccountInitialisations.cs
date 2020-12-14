using JobsLedger.DATABASE.CREATION.SERVICE.Interfaces;
using JobsLedger.MODELS.AUTHORISATION;


namespace JobsLedger.DATABASE.CREATION.SERVICE
{
    public class TenantAndAccountInitialisations: ITenantAndAccountInitialisations
    {

        private readonly INewDatabaseService _newDatabaseService;

        public TenantAndAccountInitialisations(

            INewDatabaseService newDatabaseService)
        {

            _newDatabaseService = newDatabaseService;
        }

        public void CreateTestTenantAndAccountDetails()
        {
            
            InitialiseTestDatabase();
            //InitialiseMasterDatabase();
        }

        private void InitialiseTestDatabase()
        {
            // CREATE TEST DATABASE

            var tenant = new TenantCreationRequestDto()
            {
                Database = "testDatabase",
                CompanyName = "Hobart Appliance Repairs",
                ABN = "35656413550",
                ContactFirstName = "Simon",
                ContactLastName = "O'Donald",
                OfficePhone = "0467304050",
                Address1 = "425 Manuka Rd",
                BankName = "CBA",
                BankBSB = "063145",
                BankAccount = "01003459745"
            };


            var account = new AccountCreationRequestDto
            {
                Title = "Ms",
                FirstName = "Lou",
                LastName = "Hay",
                EmailAddress = "louise@optusnet.com.au",
                Address1 = "29 Florence St",
                Password = "password",
                ConfirmPassword = "password",
                AcceptTerms = true
            };
            
            // Use these entities to create the DATABASE and account admin.
            _newDatabaseService.CreateNewDataBaseAndTenantAdmin(tenant, account);
        }

        private void InitialiseMasterDatabase()
        {
            // CREATE MASTER DATABASE

            var tenant = new TenantCreationRequestDto()
            {
                Database = "masterDatabase",
                CompanyName = "Jobs Ledger Pty Ltd",
                ABN = "35656413550",
                ContactFirstName = "Louise",
                ContactLastName = "Hay",
                OfficePhone = "0467304050",
                Address1 = "22 Florence St",
                BankName = "CBA",
                BankBSB = "063145",
                BankAccount = "01003459745"
            };

            var account = new AccountCreationRequestDto
            {
                Title = "Mr",
                FirstName = "Simon",
                LastName = "O'Farrell",
                EmailAddress = "simonofarrell@optusnet.com.au",
                Address1 = "485 Manuka Rd",
                Password = "password",
                ConfirmPassword = "password",
                AcceptTerms = true
            };

            // Use these entities to create the DATABASE and account admin.
            _newDatabaseService.CreateNewDataBaseAndTenantAdmin(tenant, account);
        }
    }
}
