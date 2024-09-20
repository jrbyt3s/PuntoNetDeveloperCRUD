//Archivo de configuraci�n al iniciar el programa, permite la inyeccion de dependencias.
// el builder es una instancia de la aplicaci�n.

using GestionDeCursos.Data.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Crear la dabaBase Connection:
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
//Registrar el contexto de base de datos ApplicationDbContext.cs:
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

// Add services to the container.
builder.Services.AddControllersWithViews(); //Model view controller

var app = builder.Build();      //optiene una instacia de la aplicaci�n.

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();       //Habilita el redireccionamiento de la p�ginas

app.UseAuthorization();     //Gestionar la sesion del usuario

app.MapControllerRoute(     //C�al es el patr�n de Ruta
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
