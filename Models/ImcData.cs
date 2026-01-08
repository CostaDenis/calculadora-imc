using System.ComponentModel.DataAnnotations;

namespace Imc.Models;

public class ImcData
{
    [Required(ErrorMessage = "Informe a altura")]
    [Range(1, 3, ErrorMessage = "Altura inválida")]
    public double? Height { get; set; }

    [Required(ErrorMessage = "Informe o peso")]
    [Range(15, 200, ErrorMessage = "Peso inválido")]
    public double? Weight { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public double Value => (Weight ?? 1) / ((Height ?? 1) * (Height ?? 1));
}