using System.Collections.Generic;
using System.Threading.Tasks;
using Datos.Data;
using Dominio.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoresController : ControllerBase
    {
        private readonly CalidadContext _context;

        public ColoresController(CalidadContext context)
        {
             _context = context;
        }
        public async Task<ActionResult<List<Color>>> GetColores()
        {
            var colores = await _context.Colores.ToListAsync();

            return colores;
        }
        [HttpGet("{codigo}")]
        public async Task<ActionResult<Color>> GetColor(int codigo)
        {
            return await _context.Colores.FindAsync(codigo);
        }
    }
}
