using AutoMapper;
using ss04.Dto;
using ss04.Models;

namespace ss04.AutomapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<BookDto,Book>();
        }
    }
}
