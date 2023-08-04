using jwt_test.Lab;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;

namespace jwt_test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var jwtOptions = builder.Configuration.GetSection("JwtOption").Get<JwtOptions>();
            builder.Services.AddSingleton(jwtOptions);

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opts =>
            {
                byte[] signingKeyBytes = Encoding.UTF8.GetBytes(jwtOptions.SigningKey);
            });

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