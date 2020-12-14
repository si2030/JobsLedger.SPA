using System.Threading.Tasks;
using JobsLedger.MODELS.AUTHORISATION;

namespace JobsLedger.DATABASE.CREATION.SERVICE.Interfaces
{
    public interface INewDatabaseService
    {
        Task<TenantCreationResponseDto> CreateNewDataBaseAndTenantAdmin(TenantCreationRequestDto tenantModel, AccountCreationRequestDto accountModel);
    }
}