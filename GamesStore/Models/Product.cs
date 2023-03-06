namespace GamesStore.Models;

//товар
public class Product
{
      public int ProductID {get; set;} //id
      public string? Name {get; set;} //название
      public string? Publisher {get; set;} //издатель
      public string? Developer {get; set;} //разрабтчик
      public decimal Price {get; set;} //цена
      public string? Description {get; set;} //описание
      public string? Category { get; set; } //категория
}