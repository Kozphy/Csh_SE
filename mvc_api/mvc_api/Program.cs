using Microsoft.EntityFrameworkCore;
using mvc_api.Models;
using Serilog;
using System.Text.Json.Serialization;

namespace mvc_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddJsonOptions(
                options => {
                    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                });

            builder.Services.AddDbContext<BlogContext>(options => 
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

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

            // setting Serilog
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console(outputTemplate: 
                "[{Timestamp:HH:mm:ss} {fileName}:{lineNum} {Level:u3}] {Message:lj} {NewLine}{Exception} ")
                .CreateLogger();

            var log = Log.Logger;


            using var scrope = app.Services.CreateScope();
            var services = scrope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<BlogContext>();
                Seed.SeedUsersData(context);
                Seed.SeedArticlesData(log,context);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "Error occured during seed data");
            }


            app.Run();
        }
    }
}