namespace JwtAuthDotNet9.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string UserName { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string? Role { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
