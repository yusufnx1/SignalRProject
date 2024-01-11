using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.Abstrack
{
    public interface IDiscountDal : IGenericDal<Discount>
    {
        void ChangeStatusTrue(int id);
        void ChangeStatusFalse(int id);
    }
}
