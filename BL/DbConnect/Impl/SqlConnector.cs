using AutoMapper;
using BL.DTO;
using BLl.DbConnect;
using Dal.DbContext;
using Dal.DbContext.MsSql;
using Dal.Models;
using System.Threading.Tasks;

namespace BLl.Impl.DbConnect
{
    public class SqlConnector : IDbConnector
    {
        private IRepository<ProviderGroup> _pRepo;

        public SqlConnector()
        {
            _pRepo = new PGroupRepository();
        }

        public async Task<ProviderGroupDto> GetProviderGroupsAsync()
        {
            var providerGroup = await Task.Run(() => _pRepo.GetProviderGroups());

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Group, GroupDto>();
                cfg.CreateMap<Provider, ProviderDto>();
                cfg.CreateMap<ProviderType, ProviderTypeDto>();
                cfg.CreateMap<ProviderGroup, ProviderGroupDto>();
            });

            var mapper = config.CreateMapper();

            return mapper.Map<ProviderGroupDto>(providerGroup);
        }
    }
}
