using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Datos.Data;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoresController : ControllerBase
    {
        private readonly IColorRepository _colorRepository;

        public ColoresController(IColorRepository colorRepository)
        {
            _colorRepository = colorRepository;
        }
        public async Task<ActionResult<List<Color>>> GetColoresAsync()
        {
            var colores = await _colorRepository.GetColoresAsync();

            return Ok(colores);
        }
        [HttpGet("{codigo}")]
        public async Task<ActionResult<Color>> GetColorPorCodigoAsync(int codigo)
        {
            return await _colorRepository.GetColorByCodigo(codigo);
        }

        
    }
}
