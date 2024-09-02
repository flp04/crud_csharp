using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ContatoController : ControllerBase
  {
    private readonly AgendaContext _context;
    public ContatoController (AgendaContext context) {
      _context = context;
    }

    [HttpPost]
    public IActionResult Create([FromBody] Contato contato)
    {
      _context.Add(contato);
      _context.SaveChanges();
      // return Ok(contato);
      return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
    }

    [HttpGet]
    public IActionResult Obter()
    {
      var contato = _context.Contatos.ToList();

      if (contato == null) return NotFound();
      
      return Ok(contato);
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
      var contato = _context.Contatos.Find(id);

      if (contato == null) return NotFound();
      
      return Ok(contato);
    }

    [HttpGet("ObterPorNome")]
    public IActionResult ObterPorNome(string nome)
    {
      var contato = _context.Contatos.Where(x => x.Nome.Contains(nome));

      if (contato == null) return NotFound();
      
      return Ok(contato);
    }

    [HttpPut("{id}")]
    public IActionResult Atualizar(int id, Contato contato)
    {
      var Contato = _context.Contatos.Find(id);

      if (Contato == null) return NotFound();

      Contato.Nome = contato.Nome;
      Contato.Telefone = contato.Telefone;
      Contato.Ativo = contato.Ativo;

      _context.Update(Contato);
      _context.SaveChanges();
      return Ok(Contato);
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(int id)
    {
      var Contato = _context.Contatos.Find(id);

      if (Contato == null) return NotFound();

      _context.Remove(Contato);
      _context.SaveChanges();
      return Ok(NoContent());
    }
  }
}