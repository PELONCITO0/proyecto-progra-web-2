using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers;

[ApiController]
[Route("api/[controller]")] // Genera la ruta automática: /api/venta
public class VentaController : ControllerBase
{
    // GET: api/venta
    [HttpGet]
    public IActionResult ObtenerVentas()
    {
        var ventas = new[]
        {
            new { Id = 101, Fecha = "2026-07-21", Total = 3500.00, Cliente = "Juan Pérez" },
            new { Id = 102, Fecha = "2026-07-21", Total = 280.00, Cliente = "Maria Lopez" }
        };

        return Ok(ventas);
    }

    // POST: api/venta (Para guardar una nueva venta enviada desde el Frontend)
    [HttpPost]
    public IActionResult CrearVenta([FromBody] object datosVenta)
    {
        // Aquí iría la lógica para guardar en la base de datos
        
        return Ok(new { 
            Mensaje = "Venta registrada con éxito", 
            Estado = true 
        });
    }
}