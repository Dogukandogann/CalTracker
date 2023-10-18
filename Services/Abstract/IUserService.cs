using Entities.Concrete;
using Entities.Enums;

namespace Services.Abstract
{
    public interface IUserService
    {
        User GetByEmail(string email);
        void Add(User user);
        void UpdateStatus(int userId, UserStatus status);
        int RecomendedCalorie(int userId, double weight, ActivitiyStatus activity);
        string CalculateBmi(int userId, double height, double weight);
        User UpdateLastnameByUserId(int userId, string newLastname);
        User UpdateUserAimByUserId(int userId, int aimId);
        User UpdateAimByUserId(int userId, double newHeight);
        User UpdateWeightByUserId(int userId, double newWeight);
        User UpdateFirstnameByUserId(int userId, string newFirstname);

    }
}