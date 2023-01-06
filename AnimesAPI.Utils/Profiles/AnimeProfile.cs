using AutoMapper;
using AnimesAPI.DTO;
using AnimesAPI.DAL.Entities;
using AnimesAPI.DAL.Enums;

namespace AnimesAPI.Utils.Mappers
{
    public class AnimeProfile : Profile
    {
        public AnimeProfile()
        {
            CreateMap<AnimeDTO, Anime>()
                .ForMember(a => a.Status, options => options.MapFrom(p => (StatusEnum)p.Status))
                .ForMember(a => a.Source, options => options.MapFrom(p => (SourceEnum)p.Source));

            CreateMap<Anime, AnimeDTO>()
                .ForMember(a => a.Status, options => options.MapFrom(p => Convert.ToInt32(p.Status)))
                .ForMember(a => a.Source, options => options.MapFrom(p => Convert.ToInt32(p.Source)));
        }
    }
}
