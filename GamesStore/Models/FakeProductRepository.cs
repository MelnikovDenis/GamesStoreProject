using System.Linq;
using System.Collections.Generic;
namespace GamesStore.Models;

public class FakeProductRepository : IProductRepository
{
      public IQueryable<Product> Products => new List<Product>
      {
            new Product{Name = "Dishonored", Price = 300M},
            new Product{Name = "Dishonored 2", Price = 500M},
            new Product{Name = "Factorio", Price = 500M},
            new Product{Name = "Supreme Commander: Forged Alliance", Price = 100M},
            new Product{Name = "Supreme Commander 2", Price = 100M}          
      }.AsQueryable<Product>();
}