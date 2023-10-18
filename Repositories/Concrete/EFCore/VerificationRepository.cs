using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Abstract.Base;

namespace Repositories.Concrete.EFCore
{
    public class VerificationRepository : BaseRepository<UserVerification>, IVerificationRepository
    {

    }
}
