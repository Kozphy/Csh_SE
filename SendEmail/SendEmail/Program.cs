using Microsoft.Extensions.FileProviders;

namespace SendEmail
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DotNetEnv.Env.Load();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDirectoryBrowser();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            //app.Logger.LogInformation(builder.Environment.ContentRootPath);

            //var node_file_provider = new PhysicalFileProvider(
            //        Path.Combine(builder.Environment.ContentRootPath, "node_modules"));
            //var node_request_path = "/node_modules";

            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = node_file_provider,
            //    RequestPath = "/node_modules"
            //});

            //app.UseDirectoryBrowser(new DirectoryBrowserOptions
            //{
            //    FileProvider = node_file_provider,
            //    RequestPath = node_request_path
            //});


            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}