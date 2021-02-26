using System.Collections.Generic;

namespace Dal.Models
{
    public class ProviderGroup
    {
        public List<Provider> providerNames { get; set; }
        public List<Group> groupNames { get; set; }
    }
}