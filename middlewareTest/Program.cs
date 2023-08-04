using middlewareTest.CustomMiddleware;

namespace middlewareTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddTransient<MyCustomMiddleware>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            // middleware
            // middleware 1
            //app.Use(async (HttpContext context, RequestDelegate next) =>
            //{
            //    await context.Response.WriteAsync("Hello");
            //    await next(context);
            //});

            // middleware UseWhen
            //app.UseWhen(
            //    context => context.Request.Query.ContainsKey("username"),
            //    app =>
            //    {
            //        app.Use(async (context, next) =>
            //        {
            //            await context.Response.WriteAsync("Hello from Middleware branch");
            //            await next();
            //        });
            //    }

            //);


            //app.Use(async (HttpContext context, RequestDelegate next) => { 
            //await context.Response.WriteAsync("Hello from main middleware.");
            //    await next(context);
            //});

            // middleware 2
            //app.UseMiddleware<MyCustomMiddleware>();
            //app.UseMyCustomMiddleware();

            // conventional middleware
            //app.UseConventional_middleware();
            //app.UseGetParametersMiddleware();

            // middleware 3
            //app.Use(async (HttpContext context, RequestDelegate next) =>
            //{
            //    await context.Response.WriteAsync(Directory.GetCurrentDirectory() + "\r\n");
            //    await next(context);
            //});

            // IConfiguration configuration = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsettings.json")
            //     .Build();

            // var env = configuration.GetValue<string>("ConnectionStrings");

            // middleware check computer device
            //app.Use(async (HttpContext context, RequestDelegate next) =>
            //{
            //    var envDevice = builder.Configuration.GetSection("laptop");
            //    if (Convert.ToBoolean(envDevice["mobile_tablet"]))
            //    {

            //        await context.Response.WriteAsync(envDevice["mobile_tablet"]! + "\r\n");
            //        await context.Response.WriteAsync("laptop env");
            //    }
            //    else
            //    {
            //        await context.Response.WriteAsync(envDevice["mobile_tablet"]! + "\r\n");
            //        await context.Response.WriteAsync("not laptop env");
            //    }

            //});


            app.Run();
        }
    }
}