using AutoMapper;
using VY.SocialMedia.Data.Contracts.Entities;
using VY.SocialMedia.Dtos.DTOs;

namespace VY.SocialMedia.Data.Implementation.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<PostEntities, PostDTO>();
            CreateMap<PostDTO, PostEntities>();
        }
    }
}
