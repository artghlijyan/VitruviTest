using System.Collections.Generic;

namespace BL.DTO
{
    public class ProviderGroupDto
    {
        public List<ProviderDto> providerNames { get; set; }
        public List<GroupDto> groupNames { get; set; }
    }
}