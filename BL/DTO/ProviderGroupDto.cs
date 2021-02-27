using System.Collections.Generic;

namespace BL.DTO
{
    public class ProviderGroupDto
    {
        public List<ProviderDto> Providers { get; set; }
        public List<GroupDto> Groups { get; set; }
        public List<ProviderTypeDto> ProviderTypes { get; set; }
    }
}