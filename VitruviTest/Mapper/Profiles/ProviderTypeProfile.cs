using AutoMapper;
using BL.DTO;
using VitruviTest.Models;

namespace VitruviTest.Mapper.Profiles
{
    public class ProviderTypeProfile : Profile
    {
        public ProviderTypeProfile()
        {
            CreateMap<ProviderTypeDto, ProviderTypeModel>();
        }
    }
}
