using Entities.Enums;

namespace Entities.Dtos
{
    public record UserForRegisterDto
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        public double Height { get; init; }
        public double Weight { get; init; }
        public UserStatus UserStatus { get; init; }
        public UserAccess UserAccess { get; init; }
        public int AimId { get; init; }
    }
}
