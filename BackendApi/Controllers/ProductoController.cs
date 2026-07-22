using Microsoft.AspNetCore.Mvc;
using BackendApi.Models;

namespace BackendApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductoController : ControllerBase
{
    // Lista en memoria (simula una base de datos)
    private static List<Producto> productos = new()
    {
        new Producto { Id = 1, Nombre = "Control PS5 DualSense", Categoria = "Accesorios", PrecioVenta = 350, Stock = 12 },
        new Producto { Id = 2, Nombre = "Consola Xbox Series S", Categoria = "Consolas", PrecioVenta = 2800, Stock = 5 },
        new Producto { Id = 3, Nombre = "Nintendo Switch OLED", Categoria = "Consolas", PrecioVenta = 3200, Stock = 8 },
        new Producto { Id = 4, Nombre = "The Last of Us Part I", Categoria = "Videojuegos", PrecioVenta = 250, Stock = 20 }
    };

    // GET: api/Producto
    [HttpGet]
    public IActionResult ObtenerProductos()
    {
        return Ok(productos);
    }

    // GET: api/Producto/5
    [HttpGet("{id}")]
    public IActionResult ObtenerProductoPorId(int id)
    {
        var producto = productos.FirstOrDefault(p => p.Id == id);

        if (producto == null)
        {
            return NotFound(new { Mensaje = "Producto no encontrado." });
        }

        return Ok(producto);
    }

    // POST: api/Producto
    [HttpPost]
    public IActionResult CrearProducto([FromBody] Producto producto)
    {
        if (producto == null)
        {
            return BadRequest();
        }

        producto.Id = productos.Any() ? productos.Max(p => p.Id) + 1 : 1;

        productos.Add(producto);

        return CreatedAtAction(
            nameof(ObtenerProductoPorId),
            new { id = producto.Id },
            producto
        );
    }

    // PUT: api/Producto/5
    [HttpPut("{id}")]
    public IActionResult ActualizarProducto(int id, [FromBody] Producto producto)
    {
        var existente = productos.FirstOrDefault(p => p.Id == id);

        if (existente == null)
        {
            return NotFound(new { Mensaje = "Producto no encontrado." });
        }

        existente.Nombre = producto.Nombre;
        existente.Categoria = producto.Categoria;
        existente.PrecioVenta = producto.PrecioVenta;
        existente.Stock = producto.Stock;

        return Ok(new
        {
            Mensaje = "Producto actualizado correctamente.",
            Producto = existente
        });
    }

    // DELETE: api/Producto/5
    [HttpDelete("{id}")]
    public IActionResult EliminarProducto(int id)
    {
        var producto = productos.FirstOrDefault(p => p.Id == id);

        if (producto == null)
        {
            return NotFound(new { Mensaje = "Producto no encontrado." });
        }

        productos.Remove(producto);

        return Ok(new
        {
            Mensaje = "Producto eliminado correctamente."
        });
    }
}