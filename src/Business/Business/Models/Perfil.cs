using System.ComponentModel.DataAnnotations;

namespace Business.Models;

public class Perfil : Entity
{

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
    public string Email { get; set; }
    public bool Ativo { get; set; }

    public DateTime RegistradoEm = DateTime.UtcNow;

    public Endereco Endereco { get; set; }
    public IEnumerable<Setup> Gear { get; set; }

}