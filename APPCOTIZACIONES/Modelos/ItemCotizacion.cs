namespace COTIZACIONES.Modelos
{
    public class ItemCotizacion
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Talla { get; set; }
        public int Cantidad { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal => Cantidad * Precio;
    }
}