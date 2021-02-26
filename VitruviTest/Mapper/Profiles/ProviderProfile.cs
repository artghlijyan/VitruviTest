using AutoMapper;
using BL.DTO;
using VitruviTest.Models;

namespace VitruviTest.Mapper.Profiles
{
    public class ProviderProfile : Profile
    {
        public ProviderProfile()
        {
            CreateMap<ProviderDto, ProviderModel>();
        }
    }
}
