using AutoMapper;
using BL.DTO;
using VitruviTest.Models;

namespace VitruviTest.Mapper.Profiles
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<GroupDto, GroupModel>();
        }
    }
}
