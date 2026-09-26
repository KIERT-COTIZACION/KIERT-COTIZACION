namespace COTIZACIONES.Modelos
{
    public class DetalleCotizacion
    {
        public int Id { get; set; }
        public int CotizacionId { get; set; }
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal => Precio * Cantidad;

        public bool EsLibre { get; set; } = false;
    }
}