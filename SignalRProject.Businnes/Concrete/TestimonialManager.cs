using SignalRProject.Businnes.Abstrack;
using SignalRProject.Data.Abstrack;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Businnes.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialManager;

        public TestimonialManager(ITestimonialDal testimonialManager)
        {
            _testimonialManager = testimonialManager;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialManager.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialManager.Delete(entity);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialManager.GetById(id);
        }

        public List<Testimonial> TGetListAll()
        {
          return _testimonialManager.GetListAll();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialManager.Update(entity);
        }
    }
}
