using AutoMapper;
using BL.DTO;
using VitruviTest.ViewModels;

namespace VitruviTest.Mapper.Profiles
{
    public class ProviderGroupModelProfile : Profile
    {
        public ProviderGroupModelProfile()
        {
            CreateMap<ProviderGroupDto, ProviderGroupModel>();
        }
    }
}
