using CarCrud.DB;
using CarCrud.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace CarCrud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<databaseContext>((services, options) =>
            {
                IConfiguration configurantion = services.GetRequiredService<IConfiguration>(); ;
                string connectionString = configurantion.GetConnectionString("DataBase");
                options.UseMySql(connectionString, new MySqlServerVersion(new Version(8,0,12)));
            });

            // Adiciona o repositório CarroRepo ao contêiner de serviços
            builder.Services.AddScoped<ICarroRepo, CarroRepo>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
