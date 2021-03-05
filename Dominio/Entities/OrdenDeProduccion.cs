using System;

namespace Dominio.Entities
{
    public class OrdenDeProduccion : BaseEntity
    {
        public int Numero{ get; set; }
        public DateTime FechaInicio{ get; set; }
        public DateTime FechaFin { get; set; }
        public Color Color{ get; set; }
        public int ColorId{ get; set; }
        public Modelo Modelo{ get; set; }
        public int ModeloId { get; set; }
    }
}