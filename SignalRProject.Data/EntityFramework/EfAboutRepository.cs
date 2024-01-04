using SignalRProject.Data.Abstrack;
using SignalRProject.Data.Concrete;
using SignalRProject.Data.Repositories;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.EntityFramework
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
        public EfAboutRepository(SignalRContext context) : base(context)
        {
        }
    }
}
