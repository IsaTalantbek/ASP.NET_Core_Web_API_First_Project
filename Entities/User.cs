namespace API_Project.Entities;

public class User
{
    public long Id { get; private set; }

    public string Name { get; private set; } = default!;

    private User() { }

    public User(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public void Rename(string newName)
    {
        // Тут можно проверить бизнес-правила
        Name = newName;
    }
}
