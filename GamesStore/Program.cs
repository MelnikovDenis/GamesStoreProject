var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddMvc(); // добавляем сервисы MVC
 
var app = builder.Build();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
//app.UseStaticFiles();
//app.UseMvc();
// устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
 
app.Run();