namespace Entities.Exceptions
{
    public class WrongCredentialsException : Exception
    {
        public WrongCredentialsException(string email) : base($"Credentials was wrong for {email}")
        {

        }

        public WrongCredentialsException() : base($"Credentials was wrong")
        {

        }
    }
}
