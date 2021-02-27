using System.Collections.Generic;

namespace Dal.Models
{
    public class ProviderGroup
    {
        public List<Provider> Providers { get; set; }
        public List<Group> Groups { get; set; }
        public List<ProviderType> ProviderTypes { get; set; }
    }
}