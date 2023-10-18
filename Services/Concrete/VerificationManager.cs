using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Concrete.EFCore;
using Services.Abstract;
using Services.Utilities.MailSender;

namespace Services.Concrete
{
    public class VerificationManager : IVerificationService
    {
        private readonly IVerificationRepository _verificationRepository = new VerificationRepository();

        public void BeginVerification(User user)
        {
            string verificationNumber = CreateVerificationNumber();

            var userVerification = new UserVerification
            {
                UserId = user.Id,
                Verification = verificationNumber
            };

            _verificationRepository.Create(userVerification);
            MailHelper.Send(user.Email, $"{Constants.Mail.MailContent.VerificationSubject}", $"{Constants.Mail.MailContent.VerificationBody}\n{verificationNumber}");

        }

        public bool ConfirmVerification(int userId, string verificationCode)
        {
            var userVerification = _verificationRepository.GetById(userId);

            if (!verificationCode.Equals(userVerification.Verification))
                throw new InvalidOperationException("Verification code is not valid");

            _verificationRepository.Delete(userVerification);
            return true;

        }

        private string CreateVerificationNumber()
        {
            return Guid.NewGuid().ToString().Substring(8).Replace('-', new Random().Next(9).ToString()[0]);
        }

    }
}
