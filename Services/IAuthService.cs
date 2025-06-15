namespace JwtAuthDotNet9.Services;

using JwtAuthDotNet9.Models;
using JwtAuthDotNet9.Entities;

public interface IAuthService
{
    Task<User?> RegisterAsync(UserDto request);
    Task<string?> LoginAsync(UserDto request);
}
