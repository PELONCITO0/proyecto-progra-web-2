using Microsoft.AspNetCore.Mvc; //Permite utilizar controladores, rutas y respuestas Http
 
namespace BackendApi.Controllers;
 
[ApiController] //Indica que la clase funcionara como un controlador de una API
[Route("api/[controller]")] //Define la ruta de la API
public class ProductoController : ControllerBase // Proporciona funciones de respuesta (Ok(), NotFound(), BadRequest())
{
    [HttpGet] //Indica que el metodo respondera a solicitudes GET
    public IActionResult ObtenerProductos()
    {
        var productos = new[]
        {
            new { Id = 1, Nombre = "Control PS5 DualSense", Categoria = "Accesorios", PrecioVenta = 350, Stock = 12 },
            new { Id = 2, Nombre = "Consola Xbox Series S", Categoria = "Consolas", PrecioVenta = 2800, Stock = 5 },
            new { Id = 3, Nombre = "Nintendo Switch OLED", Categoria = "Consolas", PrecioVenta = 3200, Stock = 8 },
            new { Id = 4, Nombre = "The Last of Us Part I", Categoria = "Videojuegos", PrecioVenta = 250, Stock = 20 }
        };
        return Ok(productos);
    }
 
    [HttpGet("{id}")]
    public IActionResult ObtenerProductoPorId(int id)
    {
        var producto = new { Id = id, Nombre = "Producto Ejemplo", Categoria = "General", PrecioVenta = 100, Stock = 10 };
        return Ok(producto);
    }
}

