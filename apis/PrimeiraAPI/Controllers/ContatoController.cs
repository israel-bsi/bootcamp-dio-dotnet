using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Context;
using PrimeiraAPI.Entities;

namespace PrimeiraAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class ContatoController(AgendaContext context) : ControllerBase
{
    [HttpPost]
    public IActionResult Create(Contato contato)
    {
        context.Add(contato);
        context.SaveChanges();
        return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
    }

    [HttpGet("{id:int}")]
    public IActionResult ObterPorId(int id)
    {
        var contato = context.Contatos.Find(id);
        if (contato == null)
            return NotFound();
        return Ok(contato);
    }

    [HttpGet("ObterPorNome")]
    public IActionResult ObterPorNome(string nome)
    {
        var contatos = context.Contatos
            .Where(c => c.Nome != null && c.Nome.Contains(nome)).ToList();
        return Ok(contatos);
    }

    [HttpGet]
    public IActionResult ObterTodos()
    {
        var contatos = context.Contatos.ToList();
        return Ok(contatos);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, Contato contato)
    {
        var contatoBanco = context.Contatos.Find(id);

        if (contatoBanco == null)
            return NotFound();

        contatoBanco.Nome = contato.Nome;
        contatoBanco.Telefone = contato.Telefone;
        contatoBanco.Ativo = contato.Ativo;

        context.Update(contatoBanco);
        context.SaveChanges();
        return Ok(contatoBanco);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var contato = context.Contatos.Find(id);
        if (contato == null)
            return NotFound();

        context.Remove(contato);
        context.SaveChanges();
        return NoContent();
    }
}