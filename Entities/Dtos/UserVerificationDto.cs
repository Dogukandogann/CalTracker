namespace Entities.Dtos
{
    public record UserVerificationDto
    {
        public int UserId { get; init; }
        public string UserEmail { get; init; }
        public string VerificationCode { get; init; }
    }
}
