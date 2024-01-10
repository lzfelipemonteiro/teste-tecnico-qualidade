using System;
using System.Collections.Generic;

namespace backend.Models
{
  public class Ensaio
  {
    public int Id { get; set; }

    // Chave estrangeira para Lote
    public int LoteId { get; set; }

    // Propriedade de navegação
    public virtual Lote? Lote { get; set; }

    public double Alongamento { get; set; }

    public double LimiteEscoamento { get; set; }

    public double LimiteResistencia { get; set; }

    public double Relacao { get; set; }

    public double MassaLinear { get; set; }

    public double Dobramento { get; set; }

    public string? Resultado { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
  }
}