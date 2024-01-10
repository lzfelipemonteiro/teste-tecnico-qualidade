using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Services;

namespace backend.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class LoteController : ControllerBase
  {

    private readonly LoteService _loteService;

    public LoteController(LoteService loteService)
    {
      _loteService = loteService;
    }

    // GET: /lote
    [HttpGet]
    public IActionResult GetLotes()
    {
      var lotes = _loteService.ObterTodosLotes();
      return Ok(lotes);
    }

    // GET: /lote/5
    [HttpGet("{id}")]
    public IActionResult GetLote(int id)
    {
      var lote = _loteService.ObterLotePorId(id);
      if (lote == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(lote);
      }
    }

    // POST: /lote
    [HttpPost]
    public IActionResult PostLote(Lote lote)
    {
      var isAddLote = _loteService.AdicionarLote(lote);
      if (!isAddLote)
      {
        return BadRequest();
      }
      return Ok();
    }

    // PUT: /lote/5
    [HttpPut("{id}")]
    public IActionResult PutLote(int id, Lote lote)
    {
      var loteAtualizado = _loteService.AtualizarLote(id, lote);
      if (loteAtualizado == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(loteAtualizado);
      }
    }

    // DELETE: /lote/5
    [HttpDelete("{id}")]
    public IActionResult DeleteLote(int id)
    {
      bool result = _loteService.DeletarLote(id);
      if (!result)
      {
        return NotFound();
      }
      else
      {
        return Ok();
      }
    }
  }

}