using System.Linq;
namespace GamesStore.Models;

public interface IProductRepository
{
      IQueryable<Product> Products {get;}
}