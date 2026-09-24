namespace COTIZACIONES.Modelos
{
    public class InventarioItem
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public int Cantidad { get; set; }
    }
}