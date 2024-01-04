using SignalRProject.Entities.Entities;

namespace SignalRProject.Businnes.Abstrack
{
    public interface ICategoryService : IGenericService<Category>
    {
        int TCategoryCount();
        int TActiveCategoryCount();
        int TPassiveCategoryCount();
    }
}
