using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Services;

namespace backend.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class EnsaioController : ControllerBase
  {
    private readonly EnsaioService _ensaioService;

    public EnsaioController(EnsaioService ensaioService)
    {
      _ensaioService = ensaioService;
    }

    // GET: /ensaio
    [HttpGet]
    public IActionResult GetEnsaio()
    {
      var ensaios = _ensaioService.ObterTodosEnsaios();
      return Ok(ensaios);
    }

    // GET: /ensaio/5
    [HttpGet("{id}")]
    public IActionResult GetEnsaio(int id)
    {
      var ensaio = _ensaioService.ObterEnsaioPorId(id);
      if (ensaio == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(ensaio);
      }
    }

    // POST: /ensaio
    [HttpPost]
    public IActionResult PostEnsaio(Ensaio ensaio)
    {
      var isAddEnsaio = _ensaioService.AdicionarEnsaio(ensaio);
      if (!isAddEnsaio)
      {
        return BadRequest();
      }
      return Ok();
    }

    // PUT: /ensaio/5
    [HttpPut("{id}")]
    public IActionResult PutEnsaio(int id, Ensaio ensaio)
    {
      var ensaioAtualizado = _ensaioService.AtualizarEnsaio(id, ensaio);
      if (ensaioAtualizado == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(ensaioAtualizado);
      }
    }

    // DELETE: /ensaio/5
    [HttpDelete("{id}")]
    public IActionResult DeleteEnsaio(int id)
    {
      bool result = _ensaioService.DeletarEnsaio(id);
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