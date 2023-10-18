using Entities.Concrete;

namespace Services
{

    public class UserNotVerifiedException : Exception
    {

        public UserNotVerifiedException(User user) : base($"Verification was not completed for: {user.Email}\nPlease Complete The Verification.")
        {
            User = user;
        }
        public User User { get; set; }

    }
}