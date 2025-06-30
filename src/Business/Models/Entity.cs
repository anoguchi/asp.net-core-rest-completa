namespace Business.Models;

public abstract class Entity
{
    // Só quem herdar dessa classe poderá fazer o uso dessa classe
    protected Entity()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
}