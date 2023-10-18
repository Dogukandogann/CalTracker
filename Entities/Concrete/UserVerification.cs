using Entities.Abstract;

namespace Entities.Concrete
{
    public class UserVerification : IEntity
    {
        public int UserId { get; set; }
        public string Verification { get; set; }
        public User User { get; set; }
    }
}
