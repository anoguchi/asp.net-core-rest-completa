namespace Business.Models;

public class Setup : Entity
{
    public Guid PerfilId { get; set; }
    public string? Mouse { get; set; }
    public string? MousePad { get; set; }
    public string? Monitor { get; set; }
    public string? Teclado { get; set; }
    public string? Resolucao { get; set; }
    public Perfil Perfil { get; set; }

}