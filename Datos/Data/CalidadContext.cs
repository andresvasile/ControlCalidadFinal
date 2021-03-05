using System.Reflection;
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
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<OrdenDeProduccion> Ordenes{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}