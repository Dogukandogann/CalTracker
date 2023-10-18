using Entities.Concrete;
using Entities.Dtos;

namespace Services
{
    public interface IAuthService
    {
        User Login(UserForLoginDto userForLogin);
        User Register(UserForRegisterDto userForRegister);
        int Verify(int userId, string verificationCode);

    }
}