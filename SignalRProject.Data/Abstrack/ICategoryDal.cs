using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.Abstrack
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
    }
}
