namespace Business.Models;

public class Perfil : Entity
{
    public DateTime RegistradoEm = DateTime.UtcNow;

    public string? Nome { get; set; }
    public string? Documento { get; set; }
    public string? Email { get; set; }
    public bool Ativo { get; set; }
    public TipoPerfil TipoPerfil { get; set; }
    public Endereco? Endereco { get; set; }
    public IEnumerable<Setup> Gear { get; set; }
}