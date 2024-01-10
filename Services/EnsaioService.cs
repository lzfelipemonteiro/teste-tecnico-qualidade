using backend.Models;
using System.Collections.Generic;
using backend.Data;
using Microsoft.EntityFrameworkCore;
// Outras dependências necessárias

namespace backend.Services
{
  public class EnsaioService
  {
    // Adicione aqui o contexto do banco de dados, se estiver usando Entity Framework
    // private readonly SeuDbContext _context;

    private readonly BackendDatabase _context;

    public EnsaioService(BackendDatabase context) // Construtor, injete dependências se necessário
    {
      // Inicialização do serviço
      _context = context;
    }

    // Método para adicionar um novo ensaio
    public bool AdicionarEnsaio(Ensaio ensaio)
    {
      try
      {
        ensaio.CreatedAt = DateTime.UtcNow;
        ensaio.UpdatedAt = DateTime.UtcNow;

        _context.Ensaios.Add(ensaio);
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

    // Método para buscar um ensaio pelo ID
    public Ensaio? ObterEnsaioPorId(int id)
    {
      try
      {
        var ensaio = _context.Ensaios.Find(id);

        if (ensaio == null)
        {
          return null; // Ensaio não encontrado
        }

        return ensaio;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null; // Falha na operação
      }
      // Retorne o ensaio encontrado
    }

    // Método para atualizar um ensaio
    public Ensaio? AtualizarEnsaio(int id, Ensaio ensaioAtualizado)
    {
      try
      {
        var ensaio = _context.Ensaios.Find(id);
        if (ensaio == null)
        {
          return null; // Ensaio não encontrado
        }

        ensaio.UpdatedAt = DateTime.UtcNow;

        ensaio.Resultado = ensaioAtualizado.Resultado;
        ensaio.Alongamento = ensaioAtualizado.Alongamento;
        ensaio.LimiteEscoamento = ensaioAtualizado.LimiteEscoamento;
        ensaio.LimiteResistencia = ensaioAtualizado.LimiteResistencia;
        ensaio.Relacao = ensaioAtualizado.Relacao;
        ensaio.MassaLinear = ensaioAtualizado.MassaLinear;
        ensaio.Dobramento = ensaioAtualizado.Dobramento;
        // Atualize outras propriedades conforme necessário

        _context.SaveChanges();
        return ensaio; // Sucesso
      }
      catch (Exception ex)
      {
        // Aqui você pode logar o erro ex, se necessário
        Console.WriteLine(ex);
        return null; // Falha na operação
      }
    }

    // Método para deletar um ensaio
    public bool DeletarEnsaio(int id)
    {
      try
      {
        var ensaio = _context.Ensaios.Find(id);

        if (ensaio == null)
        {
          return false; // Ensaio não encontrado
        }
        else
        {
          _context.Ensaios.Remove(ensaio);
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

    // Outros métodos conforme necessário, por exemplo, para buscar todos os ensaios
    public List<Ensaio>? ObterTodosEnsaios()
    {
      try
      {
        var ensaios = _context.Ensaios
        .Include(ensaio => ensaio.Lote)
        .ToList();
        return ensaios;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }
  }
}
