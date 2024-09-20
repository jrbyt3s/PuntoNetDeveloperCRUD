//Archivo de configuración al iniciar el programa, permite la inyeccion de dependencias.
// el builder es una instancia de la aplicación.

using GestionDeCursos.Data.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Crear la dabaBase Connection:
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
//Registrar el contexto de base de datos ApplicationDbContext.cs:
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

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
