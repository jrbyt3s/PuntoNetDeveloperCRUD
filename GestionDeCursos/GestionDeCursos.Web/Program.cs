//Archivo de configuración al iniciar el programa, permite la inyeccion de dependencias.
// el builder es una instancia de la aplicación.

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); //Model view controller

var app = builder.Build();      //optiene una instacia de la aplicación.

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();       //Habilita el redireccionamiento de la páginas

app.UseAuthorization();     //Gestionar la sesion del usuario

app.MapControllerRoute(     //Cúal es el patrón de Ruta
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
