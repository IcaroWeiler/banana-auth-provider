namespace Banana.Auth.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

    // Construtor vazio para o EF Core
    protected User() { }

    public User(string email, string passwordHash)
    {
        // Aqui um sênior poderia adicionar validações de domínio
        if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email é obrigatório.");
        
        Email = email;
        PasswordHash = passwordHash;
    }
}