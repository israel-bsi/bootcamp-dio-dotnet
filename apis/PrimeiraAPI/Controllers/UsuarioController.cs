using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpGet("ObterDataHora")]
    public IActionResult ObterDataHora()
    {
        var obj = new
        {
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToShortTimeString()
        };
        return Ok(obj);
    }

    [HttpGet("Apresentar/{nome}")]
    public IActionResult Apresentar(string nome)
    {
        var mensagem = $"Olá {nome}, seja bem vindo!";
        return Ok(new {mensagem});
    }
}