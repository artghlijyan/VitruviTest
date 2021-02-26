using BL.DTO;
using System.Threading.Tasks;

namespace BLl.DbConnect
{
    public interface IDbConnector
    {
        public Task<ProviderGroupDto> GetProviderGroupsAsync();
    }
}
