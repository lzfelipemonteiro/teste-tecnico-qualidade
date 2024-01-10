using backend.Models;
using System.Collections.Generic;
using backend.Data;
// Outras dependências necessárias

namespace backend.Services
{
  public class MaterialService
  {
    // Adicione aqui o contexto do banco de dados, se estiver usando Entity Framework
    // private readonly SeuDbContext _context;

    private readonly BackendDatabase _context;

    public MaterialService(BackendDatabase context) // Construtor, injete dependências se necessário
    {
      // Inicialização do serviço
      _context = context;
    }

    // Método para adicionar um novo material
    public void AdicionarMaterial(Material material)
    {
      try
      {
        material.CreatedAt = DateTime.UtcNow;
        material.UpdatedAt = DateTime.UtcNow;

        _context.Materiais.Add(material);
        _context.SaveChanges();
      }
      catch (Exception ex)
      {
        // Aqui você pode logar o erro ex, se necessário
        Console.WriteLine(ex);
      }
    }

    // Método para buscar um material pelo ID
    public Material ObterMaterialPorId(int id)
    {
      try
      {
        var material = _context.Materiais.Find(id);

        if (material == null)
        {
          return null; // Material não encontrado
        }

        return material;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null; // Falha na operação
      }
      // Retorne o material encontrado
    }

    // Método para atualizar um material
    public Material AtualizarMaterial(int id, Material materialAtualizado)
    {
      try
      {
        var material = _context.Materiais.Find(id);
        if (material == null)
        {
          return null; // Material não encontrado
        }

        material.UpdatedAt = DateTime.UtcNow;

        material.Nome = materialAtualizado.Nome;
        material.Alongamento = materialAtualizado.Alongamento;
        material.LimiteEscoamento = materialAtualizado.LimiteEscoamento;
        material.LimiteResistencia = materialAtualizado.LimiteResistencia;
        material.Relacao = materialAtualizado.Relacao;
        material.MassaLinear = materialAtualizado.MassaLinear;
        // Atualize outras propriedades conforme necessário

        _context.SaveChanges();
        return material; // Sucesso
      }
      catch (Exception ex)
      {
        // Aqui você pode logar o erro ex, se necessário
        Console.WriteLine(ex);
        return null; // Falha na operação
      }
    }

    // Método para deletar um material
    public bool DeletarMaterial(int id)
    {
      try
      {
        var material = _context.Materiais.Find(id);

        if (material == null)
        {
          return false; // Material não encontrado
        }
        else
        {
          _context.Materiais.Remove(material);
          _context.SaveChanges();
          return true; // Sucesso
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return false;
      }
    }

    // Outros métodos conforme necessário, por exemplo, para buscar todos os materiais
    public List<Material> ObterTodosMateriais()
    {
      try
      {
        var materiais = _context.Materiais.ToList();
        return materiais;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }
  }
}
