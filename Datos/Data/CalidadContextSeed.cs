using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.Extensions.Logging;


namespace Datos.Data
{
    public class CalidadContextSeed
    {
        public static async Task SeedAsync(CalidadContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Colores.Any())
                {
                    var coloresData = File.ReadAllText("../Datos/Data/SeedData/colores.json");

                    var colores = JsonSerializer.Deserialize<List<Color>>(coloresData);

                    foreach (var item in colores)
                    {
                        context.Colores.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Modelos.Any())
                {
                    var modelosData = File.ReadAllText("../Datos/Data/SeedData/modelos.json");

                    var modelos = JsonSerializer.Deserialize<List<Modelo>>(modelosData);

                    foreach (var item in modelos)
                    {
                        context.Modelos.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
                if (!context.Ordenes.Any())
                {
                    var ordenesData = File.ReadAllText("../Datos/Data/SeedData/ordenes.json");

                    var ordenes = JsonSerializer.Deserialize<List<OrdenDeProduccion>>(ordenesData);

                    foreach (var item in ordenes)
                    {
                        context.Ordenes.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<CalidadContext>();
                logger.LogError(ex.Message);
            }
        }
    }
}