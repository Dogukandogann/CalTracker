using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Abstract.Base;
using Repositories.Context;

namespace Repositories.Concrete.EFCore
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public int GetActiveUserCount()
        {
            using var context = new KaloriTakipDbContext();

            return context.Users.Count(u => u.UserStatus == Entities.Enums.UserStatus.Active);

        }
    }
}
