using AutoMapper;
using TesteAutoGlassNegocio.DTO;
using TesteAutoGlassPersistencia.Model;

namespace TesteAutoGlass.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
        }
    }
}
