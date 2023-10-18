using Entities.Concrete;

namespace Services.Abstract
{
    public interface IAimService
    {
        IEnumerable<Aim> GetAll();
    }
}