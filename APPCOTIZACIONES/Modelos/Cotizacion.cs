using System;
using System.Collections.Generic;
using System.Linq;

namespace COTIZACIONES.Modelos
{
    public class Cotizacion
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int? ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteDocumento { get; set; }
        public List<DetalleCotizacion> Detalles { get; set; } = new List<DetalleCotizacion>();
        public decimal Subtotal => Detalles.Sum(d => d.Subtotal);
        public decimal PorcentajeIGV { get; set; } = 18m;
        public bool ConIGV { get; set; } = true;
        public decimal Impuesto => ConIGV ? Subtotal * (PorcentajeIGV / 100m) : 0m;
        public decimal Total => Subtotal + Impuesto;
        public string Observaciones { get; set; }
        public int UsuarioId { get; set; }
    }
}