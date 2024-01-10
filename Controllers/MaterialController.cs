using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Services;

namespace backend.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MaterialController : ControllerBase
  {
    private readonly MaterialService _materialService;

    public MaterialController(MaterialService materialService)
    {
      _materialService = materialService;
    }

    // GET: /material
    [HttpGet]
    public IActionResult GetMateriais()
    {
      var materiais = _materialService.ObterTodosMateriais();
      return Ok(materiais);
    }

    // GET: /material/5
    [HttpGet("{id}")]
    public IActionResult GetMaterial(int id)
    {
      var material = _materialService.ObterMaterialPorId(id);
      if (material == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(material);
      }
    }

    // POST: /material
    [HttpPost]
    public IActionResult PostMaterial(Material material)
    {
      _materialService.AdicionarMaterial(material);
      return Ok();
    }

    // PUT: /material/5
    [HttpPut("{id}")]
    public IActionResult PutMaterial(int id, Material material)
    {
      var materialAtualizado = _materialService.AtualizarMaterial(id, material);
      if (materialAtualizado == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(materialAtualizado);
      }
    }

    // DELETE: /material/5
    [HttpDelete("{id}")]
    public IActionResult DeleteMaterial(int id)
    {
      bool result = _materialService.DeletarMaterial(id);
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