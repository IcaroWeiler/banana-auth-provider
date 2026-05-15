using Banana.Auth.Domain.Entities;

namespace Banana.Auth.Domain.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByEmailAsync(string email);
    Task AddAsync(User user);
    Task SaveChangesAsync();
}