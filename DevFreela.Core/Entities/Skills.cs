namespace DevFreela.Application.Entities;

public class Skills : BaseEntity
{
    public string Description { get; private set; }
    public DateTime CreateAt { get; private set; }

    public Skills(string description)
    {
        Description = description;
        CreateAt = DateTime.Now;
    }
}