using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.Abstrack
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductWhitCategories();
        int ProductCount();
        int ProductCountByCategoryNameHamburger();
        int ProductCountByCategoryNameDrink();
        decimal ProductPriceAvg();
        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();
        decimal ProductPriceByHamburger();
    }
}
