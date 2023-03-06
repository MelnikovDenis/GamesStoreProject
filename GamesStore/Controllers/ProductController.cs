using Microsoft.AspNetCore.Mvc;
using GamesStore.Models;
namespace GamesStore.Controllers;
public class ProductController : Controller
{
    private IProductRepository repository;
    public ProductController(IProductRepository repository) 
    {
        this.repository = repository;
    }
    public IActionResult List() => View(repository.Products);
}