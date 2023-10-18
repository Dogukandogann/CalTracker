using Entities.Abstract;

namespace Entities.Concrete
{
    public class Aim : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public double Coefficient { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
