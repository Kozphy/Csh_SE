using arch_seperate.Models;
using arch_seperate.Repository;
using Microsoft.EntityFrameworkCore;

namespace arch_seperate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<BlogContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BlogDb")));
            builder.Services.AddTransient<IArticleRepository, ArticleRepository>();
            builder.Services.AddTransient<IExamResultRepository, ExamResultRepository>();

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
                pattern: "{controller=ExamResult}/{action=Index}/{id?}");

            app.Run();
        }
    }
}