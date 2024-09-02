using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class Usuario : ControllerBase
  {
    [HttpGet("ObterDataHoraAtual")]
    public IActionResult ObterDataHora()
    {
      var obj = new
      {
        Data = DateTime.Now.ToLongDateString(),
        Hora = DateTime.Now.ToShortTimeString()
      };
      return Ok(obj);
    }

    [HttpGet("Ola")]
    public IActionResult Ola(string nome)
    {
      var msg = $"Olá {nome} seja bem vindo!";
      return Ok(new {msg});
    }
  }
}