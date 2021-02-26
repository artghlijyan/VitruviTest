using AutoMapper;
using BL.DbConnect;
using BL.DTO;
using Dal.DbContext;
using Dal.DbContext.MsSql;
using Dal.Models;
using System.Threading.Tasks;

namespace BL.Impl.DbConnect
{
    public class DbConnector : IDbConnector
    {
        public async Task<ProviderGroupDto> GetProviderGroupsAsync()
        {
            IDbContext context = new SqlContext();
            ProviderGroup providerGroup = await Task.Run(() => context.GetProviderGroups());

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Provider, ProviderDto>();
                cfg.CreateMap<Group, GroupDto>();
                cfg.CreateMap<ProviderGroup, ProviderGroupDto>();
            });

            var mapper = config.CreateMapper();

            return mapper.Map<ProviderGroupDto>(providerGroup);
        }


    }
}
