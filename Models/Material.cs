using System;
using System.Collections.Generic;

namespace backend.Models
{
  public class Material
  {
    public int Id { get; set; }

    public required string Nome { get; set; }

    public double Alongamento { get; set; }

    public double LimiteEscoamento { get; set; }

    public double LimiteResistencia { get; set; }

    public double Relacao { get; set; }

    public double MassaLinear { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    // Relacionamento com Lote
    [System.Text.Json.Serialization.JsonIgnore]
    public virtual ICollection<Lote>? Lotes { get; set; }
  }
}