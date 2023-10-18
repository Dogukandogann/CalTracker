using Entities.Concrete;
using Entities.Enums;
using Entities.Exceptions;
using Repositories.Abstract;
using Repositories.Concrete.EFCore;
using Services.Abstract;
using Services.Constants.Calculations;

namespace Services.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository = new UserRepository();
        private readonly IAimRepository _aimRepository = new AimRepository();

        public void Add(User user)
        {
            if (CheckIfUserExists(user.Email))
                throw new UserAlreadyExistsException(user.Email);

            _userRepository.Create(user);

        }

        public User GetByEmail(string email)
        {
            var user = _userRepository.Get(u => u.Email.Equals(email));

            if (user is null)
                throw new UserNotFoundException(email);

            return user;

        }

        public void UpdateStatus(int userId, UserStatus status)
        {

            var user = _userRepository.GetById(userId);

            user.UserStatus = status;

            _userRepository.Update(user);
        }

        public User UpdateFirstnameByUserId(int userId, string newFirstname)
        {
            var user = _userRepository.GetById(userId);

            user.FirstName = newFirstname;

            _userRepository.Update(user);

            return user;

        }

        public User UpdateLastnameByUserId(int userId, string newLastname)
        {
            var user = _userRepository.GetById(userId);

            user.LastName = newLastname;

            _userRepository.Update(user);

            return user;
        }

        public User UpdateUserAimByUserId(int userId, int aimId)
        {
            var user = _userRepository.GetById(userId);
            var aimToUpdate = _aimRepository.GetById(aimId);

            user.Aim = aimToUpdate;
            _userRepository.Update(user);

            return user;
        }

        public User UpdateAimByUserId(int userId, double newHeight)
        {
            var user = _userRepository.GetById(userId);

            user.Height = newHeight;
            _userRepository.Update(user);

            return user;
        }

        public User UpdateWeightByUserId(int userId, double newWeight)
        {
            var user = _userRepository.GetById(userId);

            user.Weight = newWeight;
            _userRepository.Update(user);

            return user;
        }

        public string CalculateBmi(int userId, double height, double weight)
        {
            var user = _userRepository.GetById(userId);

            user.Weight = weight;
            user.Height = height;
            double status = (weight / (Math.Pow(height, 2)));

            if (status < 18.5)
                return BmiStatus.UnderWeight.ToString();

            else if (status >= 18.5 && status < 25)
                return BmiStatus.NormalWeight.ToString();

            else if (status >= 25 && status < 30)
                return BmiStatus.Overweight.ToString();

            else
                return BmiStatus.Obesity.ToString();

        }

        public int RecomendedCalorie(int userId, double weight, ActivitiyStatus activity)
        {
            var user = _userRepository.GetById(userId);
            user.Weight = weight;
            if (activity == ActivitiyStatus.VeryLowActivitiy)
                return (int)(user.Weight * CalorieCalculations.TotalHour * CalorieCalculations.VeryLowActivitiy);

            else if (activity == ActivitiyStatus.LightActivity)
                return (int)(user.Weight * CalorieCalculations.TotalHour * CalorieCalculations.LightActivity);

            else if (activity == ActivitiyStatus.ModerateActivity)
                return (int)(user.Weight * CalorieCalculations.TotalHour * CalorieCalculations.ModerateActivity);

            else
                return (int)(user.Weight * CalorieCalculations.TotalHour * CalorieCalculations.HighActivity);

        }

        private bool CheckIfUserExists(string email)

            => _userRepository.Any(u => u.Email.Equals(email));

    }
}