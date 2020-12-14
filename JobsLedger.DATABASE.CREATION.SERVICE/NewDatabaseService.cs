using AutoMapper;

using Microsoft.Extensions.Options;

using System;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using JobsLedger.DATABASE.CREATION.SERVICE.Interfaces;
using JobsLedger.MODELS.AUTHORISATION;
using JobsLedger.TENANTS.ENTITIES;
using BC = BCrypt.Net.BCrypt;

namespace JobsLedger.DATABASE.CREATION.SERVICE
{
    public class NewDatabaseService : INewDatabaseService
    {
        private readonly IMapper _mapper;

        public NewDatabaseService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<TenantCreationResponseDto> CreateNewDataBaseAndTenantAdmin(TenantCreationRequestDto tenantModel, AccountCreationRequestDto accountModel)
        {
            // MAP THE TENANT DETAILS FIRST.
            var tenant = _mapper.Map<Tenant>(tenantModel);


            // MAP THE ADMIN DETAILS TO AN ACCOUNT.
            var account = _mapper.Map<Account>(accountModel);


            var tenantCreationResponseDto = new TenantCreationResponseDto();

            return tenantCreationResponseDto;
        }

        private string RandomTokenString()
        {
            using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            var randomBytes = new byte[40];
            rngCryptoServiceProvider.GetBytes(randomBytes);
            // convert random bytes to hex string
            return BitConverter.ToString(randomBytes).Replace("-", "");
        }
    }
}