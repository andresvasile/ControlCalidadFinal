using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Datos.Data
{
    public class CalidadContext : DbContext
    {
        public CalidadContext(DbContextOptions<CalidadContext> options ) :
            base(options)
        {
            
        }
        public DbSet<Color> Colores { get; set; }
    }

}