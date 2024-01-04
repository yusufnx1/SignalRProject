using SignalRProject.Entities.Entities;

namespace SignalRProject.Businnes.Abstrack
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductWhitCategories();
        int TProductCount();
        int TProductCountByCategoryNameHamburger();
        int TProductCountByCategoryNameDrink();
        decimal TProductPriceAvg();
        string TProductNameByMaxPrice();
        string TProductNameByMinPrice();
        decimal TProductPriceByHamburger();

    }
}
