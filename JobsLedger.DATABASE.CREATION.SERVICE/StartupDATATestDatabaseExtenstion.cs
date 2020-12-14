using JobsLedger.DATABASE.CREATION.SERVICE.Interfaces;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using System;

namespace JobsLedger.DATABASE.CREATION.SERVICE
{
    public static class StartupDATATestDatabaseExtenstion
    {
        public static void CreateTestDatabaseAccountsAndData(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();



            // Lets get the test database tenant and account details.

            serviceScope.ServiceProvider.GetService<ITenantAndAccountInitialisations>().CreateTestTenantAndAccountDetails();
 
        }
    }
}
