using DI_Container.Class;
using DI_Container.Interface;
using DI_Container.SampleDI;

namespace DI_Container
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddScoped<IScoped, SampleClass>();
            builder.Services.AddScoped<ISingleton, SampleClass>();
            builder.Services.AddScoped<ITransient, SampleClass>();
            builder.Services.AddScoped<SampleService, SampleService>();

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
                pattern: "{controller=Sample}/{action=Get}/{id?}");

            app.Run();
        }
    }
}