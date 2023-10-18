namespace Entities.Dtos
{
    public record UserForLoginDto
    {
        public string Email { get; init; }
        public string Password { get; init; }

    }

}
