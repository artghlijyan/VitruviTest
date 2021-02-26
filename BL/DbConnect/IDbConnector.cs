using BL.DTO;
using System.Threading.Tasks;

namespace BL.DbConnect
{
    public interface IDbConnector
    {
        public Task<ProviderGroupDto> GetProviderGroupsAsync();
    }
}
