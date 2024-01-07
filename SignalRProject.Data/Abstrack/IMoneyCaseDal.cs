using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.Abstrack
{
    public interface IMoneyCaseDal : IGenericDal<MoneyCase>
    {
        decimal TotalMoneyCaseAmount();
    }
}
