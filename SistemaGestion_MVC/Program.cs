using DatosMaestros_Modelos;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using SistemaG_API_Consumer;
using Log_Modelos;

namespace SistemaGestion_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Crud<Camion>.EndPoint = "https://localhost:7079/api/Camiones";
            Crud<Login>.EndPoint = "https://localhost:7079/api/Logins";
            Crud<Conductor>.EndPoint = "https://localhost:7079/api/Conductores";
            Crud<MantenimientoProgramado>.EndPoint = "https://localhost:7079/api/MantenimientoProgramados";
            Crud<Taller>.EndPoint = "https://localhost:7079/api/Talleres";
            Crud<Usuario>.EndPoint = "https://localhost:7079/api/Usuarios";

            Crud<Sensor>.EndPoint = "http://localhost:5181/api/Sensores";
            Crud<AlertaMantenimiento>.EndPoint = "http://localhost:5181/api/AlertaMantenimientos";

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=IndexPrincipal}/{id?}");

            app.Run();
        }
    }
}
