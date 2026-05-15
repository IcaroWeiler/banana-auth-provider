namespace Banana.Auth.Domain.Entities;

public class User
{
    public int Id { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public DateTime CreatedAt { get; private set; }

    protected User() { }

    // Construtor principal para o negócio
    public User(string email, string passwordHash)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("O e-mail não pode ser vazio.");

        if (string.IsNullOrWhiteSpace(passwordHash))
            throw new ArgumentException("O hash da senha é obrigatório.");

        Email = email.ToLower().Trim();
        PasswordHash = passwordHash;
        CreatedAt = DateTime.UtcNow;
    }

    public void UpdateEmail(string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail)) throw new ArgumentException("E-mail inválido.");
        Email = newEmail.ToLower().Trim();
    }
}