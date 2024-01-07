using SignalRProject.Entities.Entities;

namespace SignalRProject.Businnes.Abstrack
{
    public interface IMoneyCaseService : IGenericService<MoneyCase>
    {
        decimal TTotalMoneyCaseAmount();
    }
}
