namespace DinetApi.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public string? Precio { get; set; }
        public DateTime? FechaCreacion { get; set; }    
        public string? vFechaCreacion { get; set; }
    }
}
