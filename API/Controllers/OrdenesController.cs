using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenesController : ControllerBase
    {
        private readonly IOrdenesRepository _repoOrdenes;
        private readonly IColorRepository _repoColores;
        private readonly IModeloRepository _repoModelos;

        public OrdenesController(IOrdenesRepository repoOrdenes
            , IColorRepository repoColores
            , IModeloRepository repoModelos)
        {
            _repoOrdenes = repoOrdenes;
            _repoColores = repoColores;
            _repoModelos = repoModelos;
        }

        public async Task<ActionResult<List<OrdenDeProduccion>>> GetOrdenesAsync()
        {
            var ordenes = await _repoOrdenes.GetOrdenesAsync();

            return Ok(ordenes);
        }

        [HttpGet("{numero}")]
        public async Task<ActionResult<OrdenDeProduccion>> GetOrdenAsync(int numero)
        {
            return await _repoOrdenes.GetOrdenByIdAsync(numero);
        }

    }
}
