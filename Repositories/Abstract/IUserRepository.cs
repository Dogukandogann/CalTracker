using Entities.Concrete;
using Repositories.Abstract.Base;

namespace Repositories.Abstract
{
    public interface IUserRepository : IBaseRepository<User>
    {
        int GetActiveUserCount();

    }
}