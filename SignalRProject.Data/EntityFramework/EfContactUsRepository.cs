using SignalRProject.Data.Abstrack;
using SignalRProject.Data.Concrete;
using SignalRProject.Data.Repositories;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.EntityFramework
{
    public class EfContactUsRepository : GenericRepository<ContactUs>, IContactUsDal
    {
        public EfContactUsRepository(SignalRContext context) : base(context)
        {
        }
    }
}
