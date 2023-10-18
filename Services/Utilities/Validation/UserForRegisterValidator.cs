using Entities.Dtos;
using FluentValidation;
using FluentValidation.Results;
using System.Text.RegularExpressions;

namespace Services.Utilities.Validation.FluentValidation
{
    public class UserForRegisterValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserForRegisterValidator()
        {
            RuleFor(user => user.FirstName)
                    .NotEmpty()
                    .WithMessage("Please specify a first name");

            RuleFor(user => user.LastName)
                    .NotEmpty()
                    .WithMessage("Please specify a last name");

            RuleFor(user => user.Password)
                    .NotEmpty()
                    .WithMessage("Please specify a password")
                    .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                    .MaximumLength(16).WithMessage("Your password length must not exceed 16.")
                    .Must(HasUpperCase).WithMessage("Your password must contain at least one uppercase letter.")
                    .Must(HasLowerCase).WithMessage("Your password must contain at least one lowercase letter.")
                    .Must(HasDigit).WithMessage("Your password must contain at least one number.")
                    .Must(HasSymbol).WithMessage("Your password must contain at least one special character.");


            RuleFor(user => user.Email)
                        .EmailAddress()
                        .WithMessage("Please specify a valid email");
        }

        protected override void RaiseValidationException(ValidationContext<UserForRegisterDto> context, ValidationResult result)
        {
            var arr = result.Errors.Select(e => $"{e.PropertyName}: {e.ErrorMessage}\n");
            var message = string.Join(string.Empty, arr).TrimEnd();
            throw new ValidationException(message);
        }

        private bool HasLowerCase(string pw) => new Regex("[a-z]+").IsMatch(pw);
        private bool HasUpperCase(string pw) => new Regex("[A-Z]+").IsMatch(pw);
        private bool HasDigit(string pw) => new Regex("(\\d)+").IsMatch(pw);
        private bool HasSymbol(string pw) => new Regex("(\\W)+").IsMatch(pw);
    }
}
