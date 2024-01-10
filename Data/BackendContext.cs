using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
  public class BackendDatabase : DbContext
  {
    public BackendDatabase(DbContextOptions<BackendDatabase> options)
        : base(options)
    {
    }

    public DbSet<Material> Materiais { get; set; }
    public DbSet<Lote> Lotes { get; set; }
    public DbSet<Ensaio> Ensaios { get; set; }
    // Defina DbSets para outras entidades, se necessário
  }
}
