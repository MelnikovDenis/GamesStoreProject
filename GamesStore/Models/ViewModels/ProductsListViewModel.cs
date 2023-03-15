using System.Collections.Generic;
using GamesStore.Models;
namespace GamesStore.Models.ViewModels;
public class ProductsListViewModel 
{
      public IEnumerable<Product> Products { get; set; }
      public PagingInfo PagingInfo { get; set; }
      public ProductsListViewModel(IEnumerable<Product> Products, PagingInfo PagingInfo)
      {
            this.Products = Products;
            this.PagingInfo = PagingInfo;
      }
}