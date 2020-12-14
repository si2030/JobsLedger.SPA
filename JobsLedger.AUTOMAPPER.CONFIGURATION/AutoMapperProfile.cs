using AutoMapper;
using JobsLedger.MODELS.AUTHORISATION;
using JobsLedger.TENANTS.ENTITIES;

namespace JobsLedger.AUTOMAPPER.CONFIGURATION
{
    public class AutoMapperProfile : Profile
    {
        // mappings between model and entity objects
        public AutoMapperProfile()
        {
            // Authorisation mappings
            CreateMap<Account, AccountCreationResponseDto>();

            CreateMap<Account, AuthenticateResponseDto>();

            CreateMap<AccountCreationRequestDto, Account>();

            CreateMap<CreateRequestDto, Account>();

            // Tenant authorisations
            CreateMap<TenantCreationRequestDto, Tenant>();
            CreateMap<Tenant, TenantCreationRequestDto>();

            CreateMap<Tenant, TenantCreationResponseDto>();



            CreateMap<UpdateRequestDto, Account>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                        {
                            // ignore null & empty string properties
                            if (prop == null) return false;
                            if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                            // ignore null role
                            if (x.DestinationMember.Name == "Role" && src.Role == null) return false;

                            return true;
                        }
                ));

            CreateMap<TenantCreationRequestDto, Tenant>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                        {
                            // ignore null & empty string properties
                            if (prop == null) return false;
                            if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                            return true;
                        }
                    ));

            CreateMap<AccountCreationRequestDto, Account>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));
        }
    }
}