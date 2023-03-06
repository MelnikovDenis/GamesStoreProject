using Microsoft.AspNetCore.Mvc;
using GamesStore.Models;
namespace GamesStore.Controllers;
public class ProductController : Controller
{
    private IProductRepository Repository {get; set;}
    public int PageSize {get; set;} = 4;
    public ProductController(IProductRepository repository) 
    {
        this.Repository = repository;
    }
    public IActionResult List(int productPage)
    {
        return View((from product in Repository.Products
            orderby product.ProductID
            select product).Skip((productPage - 1) * PageSize).Take(PageSize)
        );
    }
}