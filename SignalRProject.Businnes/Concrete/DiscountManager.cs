using SignalRProject.Businnes.Abstrack;
using SignalRProject.Data.Abstrack;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Businnes.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void TAdd(Discount entity)
        {
            _discountDal.Add(entity);
        }

        public void TChangeStatusFalse(int id)
        {
            _discountDal.ChangeStatusFalse(id);
        }

        public void TChangeStatusTrue(int id)
        {
            _discountDal.ChangeStatusTrue(id);
        }

        public void TDelete(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public Discount TGetById(int id)
        {
            return _discountDal.GetById(id);
        }

        public List<Discount> TGetListAll()
        {
           return _discountDal.GetListAll();
        }

        public void TUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
