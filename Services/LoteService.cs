using backend.Models;
using System.Collections.Generic;
using backend.Data;
using Microsoft.EntityFrameworkCore;
// Outras dependências necessárias

namespace backend.Services
{
  public class LoteService
  {
    // Adicione aqui o contexto do banco de dados, se estiver usando Entity Framework
    // private readonly SeuDbContext _context;

    private readonly BackendDatabase _context;

    public LoteService(BackendDatabase context) // Construtor, injete dependências se necessário
    {
      // Inicialização do serviço
      _context = context;
    }

    // Método para adicionar um novo lote
    public bool AdicionarLote(Lote lote)
    {
      try
      {
        lote.CreatedAt = DateTime.UtcNow;
        lote.UpdatedAt = DateTime.UtcNow;

        lote.Status = "Pendente";

        _context.Lotes.Add(lote);
        _context.SaveChanges();
        return true; // Sucesso
      }
      catch (Exception ex)
      {
        // Aqui você pode logar o erro ex, se necessário
        Console.WriteLine(ex);
        return false; // Falha na operação
      }
    }

    // Método para buscar um lote pelo ID
    public Lote? ObterLotePorId(int id)
    {
      try
      {
        var lote = _context.Lotes.Find(id);

        if (lote == null)
        {
          return null; // Lote não encontrado
        }

        return lote;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null; // Falha na operação
      }
      // Retorne o lote encontrado
    }

    // Método para atualizar um lote
    public Lote? AtualizarLote(int id, Lote loteAtualizado)
    {
      try
      {
        var lote = _context.Lotes.Find(id);
        if (lote == null)
        {
          return null; // Lote não encontrado
        }

        lote.UpdatedAt = DateTime.UtcNow;

        lote.Identificador = loteAtualizado.Identificador;
        lote.Quantidade = loteAtualizado.Quantidade;
        lote.Status = loteAtualizado.Status;
        // Atualize outras propriedades conforme necessário

        _context.SaveChanges();
        return lote; // Sucesso
      }
      catch (Exception ex)
      {
        // Aqui você pode logar o erro ex, se necessário
        Console.WriteLine(ex);
        return null; // Falha na operação
      }
    }

    // Método para deletar um lote
    public bool DeletarLote(int id)
    {
      try
      {
        var lote = _context.Lotes.Find(id);

        if (lote == null)
        {
          return false; // Lote não encontrado
        }
        else
        {
          _context.Lotes.Remove(lote);
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

    // Outros métodos conforme necessário, por exemplo, para buscar todos os lotes
    public List<Lote>? ObterTodosLotes()
    {
      try
      {
        var lotes = _context.Lotes
        .Include(l => l.Material) // Inclua o material relacionado
        .ToList();
        return lotes;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }
  }
}
