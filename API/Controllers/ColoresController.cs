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
    public class ColoresController : BaseApiController
    {
        private readonly IGenericRepository<Color> _colorRepository;

        public ColoresController(IGenericRepository<Color> colorRepository)
        {
            _colorRepository = colorRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Color>>> GetColoresAsync()
        {
            var colores = await _colorRepository.ListAllAsync();

            return Ok(colores);
        }
        [HttpGet("{codigo}")]
        public async Task<ActionResult<Color>> GetColorPorCodigoAsync(int codigo)
        {
            return await _colorRepository.GetByIdAsync(codigo);
        }

        
    }
}
