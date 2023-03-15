using Microsoft.AspNetCore.Mvc;
using GamesStore.Models;
using GamesStore.Models.ViewModels;
namespace GamesStore.Controllers;
public class ProductController : Controller
{
    private IProductRepository Repository {get; set;}
    public int PageSize {get; set;} = 4;
    public ProductController(IProductRepository repository) 
    {
        this.Repository = repository;
    }
    [HttpGet]
    public IActionResult List(int productPage)
    {
        return View(new ProductsListViewModel((from product in Repository.Products
                orderby product.ProductID
                select product).Skip((productPage - 1) * PageSize).Take(PageSize),
                new PagingInfo {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = Repository.Products.Count()
                }
            )
        );
    }
}