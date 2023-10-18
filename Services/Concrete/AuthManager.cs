using Entities.Concrete;
using Entities.Dtos;
using Entities.Enums;
using Entities.Exceptions;
using FluentValidation;
using Services.Abstract;
using Services.Utilities.Hashing;
using Services.Utilities.Validation.FluentValidation;

namespace Services.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IVerificationService _verificationService = new VerificationManager();
        private readonly IUserService _userService = new UserManager();
        private readonly IValidator<UserForRegisterDto> _userForRegisterValidator = new UserForRegisterValidator();

        public User Login(UserForLoginDto userForLogin)
        {
            var user = _userService.GetByEmail(userForLogin.Email);

            var IsAuthenticated = HashingHelper.VerifyPasswordHash(userForLogin.Password, user.PasswordHash, user.PasswordSalt);

            if (!IsAuthenticated)
                throw new WrongCredentialsException(userForLogin.Email);

            if (user.UserStatus == UserStatus.NotVerified)
                throw new UserNotVerifiedException(user);
            return user;
        }

        public User Register(UserForRegisterDto userForRegister)
        {
            _userForRegisterValidator.ValidateAndThrow(userForRegister);

            byte[] passwordHash;
            byte[] passwordSalt;

            HashingHelper.CreatePasswordHash(userForRegister.Password, out passwordHash, out passwordSalt);

            var user = new User
            {
                FirstName = userForRegister.FirstName,
                LastName = userForRegister.LastName,
                Email = userForRegister.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Height = userForRegister.Height,
                Weight = userForRegister.Weight,
                UserStatus = UserStatus.NotVerified,
                AimId = userForRegister.AimId,
                UserVerification = null

            };

            _userService.Add(user);

            _verificationService.BeginVerification(user);
            return user;

        }

        public int Verify(int userId, string verificationCode)
        {
            _verificationService.ConfirmVerification(userId, verificationCode);
            _userService.UpdateStatus(userId, UserStatus.Active);
            return userId;

        }
    }
}