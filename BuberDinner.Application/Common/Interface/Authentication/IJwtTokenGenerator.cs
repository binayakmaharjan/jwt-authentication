using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.Interface.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}