var builder = WebApplication.CreateBuilder(args);

// Agregar soporte para MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Manejo de errores en producción
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Redirección HTTPS
app.UseHttpsRedirection();

// 🔥 Necesario para CSS, Bootstrap, JS
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Ruta por defecto (inicia en Productos)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Productos}/{action=Index}/{id?}");

app.Run();