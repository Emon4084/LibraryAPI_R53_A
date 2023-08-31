using AutoMapper;
using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.DTOs;

namespace LibraryAPI_R53_A.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PublisherDto, Publisher>();
        }
    }
}
