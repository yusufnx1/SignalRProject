using SignalRProject.Data.Abstrack;
using SignalRProject.Data.Concrete;
using SignalRProject.Data.Repositories;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.EntityFramework
{
    public class EfTestimonialRepository : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimonialRepository(SignalRContext context) : base(context)
        {
        }
    }
}
