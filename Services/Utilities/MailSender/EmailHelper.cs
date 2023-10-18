using FluentEmail.Smtp;
using FluentEmail.Core;
using Services.Constants.Mail;

namespace Services.Utilities.MailSender
{

    public static class MailHelper
    {

        private static SmtpSender sender = new SmtpSender(() => new System.Net.Mail.SmtpClient
        {
            Host = MailSettings.Host,
            Port = MailSettings.Port,
            UseDefaultCredentials = false,
            Credentials = new System.Net.NetworkCredential(MailSettings.MailAddress, MailSettings.Password),
            EnableSsl = true,
        });

        public static void Send(string to, string subject, string body)
        {
            Email.DefaultSender = sender;

            var email = Email
                        .From(MailSettings.MailAddress)
                        .To(to)
                        .Subject(subject)
                        .Body(body);

            var response = email.Send();
        }

    }

}






