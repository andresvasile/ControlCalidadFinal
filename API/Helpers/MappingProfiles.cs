using API.Dtos;
using AutoMapper;
using Dominio.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<OrdenDeProduccion, OrdenDto>()
                .ForMember(o=>o.Modelo,o=>o.MapFrom(s=>s.Modelo.Denominacion))
                .ForMember(o => o.Color, o => o.MapFrom(s => s.Color.Descripcion));

        }
    }
}