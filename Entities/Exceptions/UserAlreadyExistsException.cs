namespace Entities.Exceptions
{
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException(string email) : base($"The email address: {email} is already being used by another user")
        {

        }


    }
}
