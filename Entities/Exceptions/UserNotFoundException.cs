namespace Entities.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string email) : base($"Email:{email} not found")
        {

        }
    }

}