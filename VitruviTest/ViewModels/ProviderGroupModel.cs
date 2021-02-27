using System.Collections.Generic;
using VitruviTest.Models;

namespace VitruviTest.ViewModels
{
    public class ProviderGroupModel
    {
        public List<GroupModel> Groups { get; set; }
        public List<ProviderModel> Providers { get; set; }
        public List<ProviderTypeModel> ProviderTypes { get; set; }
    }
}
