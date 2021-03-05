using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Specifications;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    public class OrdenesController : BaseApiController
    {
        private readonly IGenericRepository<OrdenDeProduccion> _repoOrdenes;
        private readonly IMapper _mapper;

        public OrdenesController(IGenericRepository<OrdenDeProduccion> repoOrdenes, IMapper mapper)
        {
            _repoOrdenes = repoOrdenes;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<OrdenDto>>> GetOrdenesAsync()
        {
            var spec = new OrdenConColoresYModelosSpecification();

            var ordenes = await _repoOrdenes.ListAsync(spec);

            return Ok(_mapper.Map<IReadOnlyList<OrdenDeProduccion>,IReadOnlyList<OrdenDto>>(ordenes));
        }

        [HttpGet("{numero}")]
        public async Task<ActionResult<OrdenDto>> GetOrdenAsync(int numero)
        {
            var spec = new OrdenConColoresYModelosSpecification(numero);

            var ordenDeP= await _repoOrdenes.GetEntityWithSpec(spec);

            return _mapper.Map<OrdenDeProduccion, OrdenDto>(ordenDeP);
        }

    }
}
