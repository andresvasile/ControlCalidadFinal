using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelosController : ControllerBase
    {
        private readonly IModeloRepository _repoModelos;

        public ModelosController(IModeloRepository repoModelos)
        {
            _repoModelos = repoModelos;
        }

        [HttpGet] 
        public async Task<ActionResult<List<Modelo>>> GetModelosAsync()
        {
            var modelos = await _repoModelos.GetModelosAsync();

            return Ok(modelos);
        }

        [HttpGet("{sku}")]
        
        public async Task<ActionResult<Modelo>> GetModeloBySkuAsync(string sku)
        {
            return await _repoModelos.GetModeloBySkuAsync(sku);
        }

        
    }
}
