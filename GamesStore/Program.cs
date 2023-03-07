using GamesStore.Models;
var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddMvc(); // добавляем сервисы MVC
services.AddTransient<IProductRepository, FakeProductRepository>(); 

var app = builder.Build();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
//app.UseStaticFiles();
//app.UseMvc();

// устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(
    name: "pagination",    
    pattern: "Products/Page{productPage}",
    defaults: new { Controller = "Product", action = "List" }
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=List}/{id?}"
);
 
app.Run();