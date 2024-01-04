using SignalRProject.Data.Abstrack;
using SignalRProject.Data.Concrete;
using SignalRProject.Data.Repositories;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.EntityFramework
{
    public class EfSocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaRepository(SignalRContext context) : base(context)
        {
        }
    }
}
