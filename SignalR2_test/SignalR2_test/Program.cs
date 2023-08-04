using Microsoft.EntityFrameworkCore;
using SignalR2_test.Hubs;
using SignalR2_test.Models;

namespace SignalR2_test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddSignalR();

            builder.Services.AddDbContext<demoContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DemoConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.MapRazorPages();
            app.MapControllerRoute(
                name:"default",
                pattern: "{controller=Home}/{action=Index}"
            );
            app.MapHub<ChatHub>("/chatHub");

            app.Run();
        }
    }
}