namespace BackendApi.Models;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Categoria { get; set; } = "";
    public decimal PrecioVenta { get; set; }
    public int Stock { get; set; }
}