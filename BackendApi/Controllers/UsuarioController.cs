using Microsoft.AspNetCore.Mvc;
using backendApi.Models;

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
    [HttpPost]
    public IActionResult CrearUsuario([FromBody] Usuario usuario)
    {
     return Ok (new
     {
      mensaje= "Usuario creado exitosamente",usuario   
     });   
    }
    [HttpPut("{id}")]
    public IActionResult ActualizarUsuario(int id, [FromBody] Usuario usuario)
    {
        return Ok(new
        {
            mensaje = "Usuario actualizado exitosamente",
            usuario
        });
    }
    [HttpDelete("{id}")]
 
    public IActionResult EliminarUsuario(int id)
    {
        
        return Ok(new 
        {
            mensaje = $"Usuario con ID {id} eliminado exitosamente"
        });
    }
}
