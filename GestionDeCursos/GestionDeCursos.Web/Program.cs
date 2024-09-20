//Archivo de configuraci�n al iniciar el programa, permite la inyeccion de dependencias.
// el builder es una instancia de la aplicaci�n.

var builder = WebApplication.CreateBuilder(args);

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
