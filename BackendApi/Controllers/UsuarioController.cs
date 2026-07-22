using Microsoft.AspNetCore.Mvc;
 
namespace BackendApi.Controllers;
 
[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpGet]
    public IActionResult ObtenerUsuarios()
    {
        var usuarios = new[]
        {
            new { Id = 1, Username = "cristhian", Rol = "Administrador" },
            new { Id = 2, Username = "jperez", Rol = "Vendedor" },
            new { Id = 3, Username = "mlopez", Rol = "Tecnico" }
        };
        return Ok(usuarios);
    }
 
    [HttpGet("{id}")]
    public IActionResult ObtenerUsuarioPorId(int id)
    {
        var usuario = new { Id = id, Username = "usuario.ejemplo", Rol = "Vendedor" };
        return Ok(usuario);
    }
 
    [HttpPost("login")]
    public IActionResult Login([FromBody] object datosLogin)
    {
        var usuario = new { Id = 1, Username = "cristhian", Rol = "Administrador" };
        return Ok(usuario);
    }
}
