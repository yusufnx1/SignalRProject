using Microsoft.EntityFrameworkCore;
using SignalRProject.Data.Abstrack;
using SignalRProject.Data.Concrete;
using SignalRProject.Data.Repositories;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
        public EfProductRepository(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductWhitCategories()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public int ProductCount()
        {
            var context = new SignalRContext();
            var values = context.Products.Count();
            return values;
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryId ==
            (context.Categories.Where(y => y.CategoryName == "İçecek")
            .Select(z => z.CategoryId).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryId ==
            (context.Categories.Where(y => y.CategoryName == "Hamburger")
            .Select(z => z.CategoryId).FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.Price ==
            (context.Products.Max(y => y.Price)))
                .Select(z => z.ProductName)
                .FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.Price ==
            (context.Products.Min(y => y.Price)))
                .Select(z => z.ProductName)
                .FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new SignalRContext();
            return context.Products.Average(x => x.Price);
        }

        public decimal ProductPriceByHamburger()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryId ==
            (context.Categories.Where(y => y.CategoryName == "Hamburger")
            .Select(z => z.CategoryId).FirstOrDefault()))
                .Average(w => w.Price);
        }
    }
}
