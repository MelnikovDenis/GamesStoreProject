using GamesStore.Models;
namespace GamesStoreTests;

public class FakeProductRepositoryTests
{
    [Fact]
    public void Test1()
    {
        var repository = new GamesStore.Models.FakeProductRepository();
        Assert.Equal("Dishonored", repository.Products.First().Name);
        Assert.Equal(5, repository.Products.Count());
    }
}