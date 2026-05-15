using Banana.Auth.Domain.Entities;

namespace Banana.Auth.Domain.Interfaces;

public interface ITokenService
{
    string GenerateToken(User user);
}