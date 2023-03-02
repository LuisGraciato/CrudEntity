using System.ComponentModel.DataAnnotations;

namespace CrudDomain.Dtos;

public class CadastroCreateDto
{
    [Required]
    [MaxLength(20)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [MaxLength(12)]
    public string Mobile { get; set; } = string.Empty;
    [Required]
    [MaxLength(50)]
    public string Address { get; set; } = string.Empty;
}

