using AutoMapper;
using ss08_api.Data;
using ss08_api.Models;

namespace ss08_api.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        {
            CreateMap<Book,BookModel>().ReverseMap();
        }

    }
}
