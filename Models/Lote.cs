using System;
using System.Collections.Generic;

namespace backend.Models
{
  public class Lote
  {
    public int Id { get; set; }

    // Chave estrangeira para Material
    public required int MaterialId { get; set; }

    // Propriedade de navegação
    public virtual Material? Material { get; set; }

    public required string Identificador { get; set; }
    public required double Quantidade { get; set; }

    public string? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    // Relacionamento com Ensaio
    [System.Text.Json.Serialization.JsonIgnore]
    public virtual ICollection<Ensaio>? Ensaios { get; set; }
  }
}