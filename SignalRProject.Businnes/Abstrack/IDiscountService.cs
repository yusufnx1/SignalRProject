using SignalRProject.Entities.Entities;

namespace SignalRProject.Businnes.Abstrack
{
    public interface IDiscountService : IGenericService<Discount>
    {
        void TChangeStatusTrue(int id);
        void TChangeStatusFalse(int id);
    }
}
