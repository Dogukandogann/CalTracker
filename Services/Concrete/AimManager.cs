using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Concrete.EFCore;
using Services.Abstract;

namespace Services.Concrete
{
    public class AimManager : IAimService
    {
        private readonly IAimRepository _aimRepository = new AimRepository();

        public IEnumerable<Aim> GetAll()
        {
            return _aimRepository.GetAll();
        }
    }
}
