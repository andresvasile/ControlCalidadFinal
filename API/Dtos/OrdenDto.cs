using System;


namespace API.Dtos
{
    public class OrdenDto
    {
        public int Numero { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
    }
}