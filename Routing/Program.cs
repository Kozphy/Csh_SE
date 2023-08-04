using Microsoft.Extensions.FileProviders;
using Routing.CustomerRouterConstraint;

namespace Routing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // add custom route constraint to app
            builder.Services.AddRouting(options =>
            {
                options.ConstraintMap.Add("months", typeof(monthConstraints));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            Console.WriteLine(builder.Environment.ContentRootPath);
            app.UseStaticFiles(new StaticFileOptions() { 
                FileProvider = new PhysicalFileProvider(
                Path.Combine(builder.Environment.ContentRootPath, "myWebRoot"))
            });

            app.UseRouting();

            // endpoint
            // app.UseEndpoints(endpoints =>
            // {
            //     // add your endpoints here

            //     endpoints.MapGet("map1", async (context) =>
            //     {
            //         await context.Response.WriteAsync("In Map 1");
            //     });

            //     endpoints.MapPost("map2", async (context) =>
            //     {
            //         await context.Response.WriteAsync("In Map 2");
            //     });
            // });


            //app.Use(async (HttpContext context, RequestDelegate next) =>
            //{
            //    Endpoint endPoint = context.GetEndpoint();
            //    if (endPoint != null)
            //    {
            //        await context.Response.WriteAsync($"Endpoint: {endPoint.DisplayName} \n");
            //    }
            //await next(context);
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("files/{filename}.{extension}", async context =>
            //    {
            //        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
            //        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
            //        await context.Response.WriteAsync($"In files -{fileName} - {extension}");
            //    });
            //    // Eg: employee/profile
            //    endpoints.Map("employee/profile/{EmployName:length(4,7):alpha=harsha}", async context =>
            //    {
            //        string? employName = Convert.ToString(context.Request.RouteValues["employname"]);
            //        await context.Response.WriteAsync($"In Employee profile - {employName}");
            //    });

            //    // Eg: products/details
            //    endpoints.Map("products/details/{id:int:range(1,1000)?}", async context =>
            //    {
            //        if (context.Request.RouteValues.ContainsKey("id"))
            //        {
            //            string? id = Convert.ToString(context.Request.RouteValues["id"]);
            //            await context.Response.WriteAsync($"Products details - {id}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync($"Products details - id is not supplied");
            //        }
            //    });

            //    // Eg: daily-digest-report/{reportdate}
            //    endpoints.Map("daily-digest-report/{reportdate:datetime}", async context =>
            //    {
            //        DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
            //        await context.Response.WriteAsync($"In daily-digest-report - {reportDate.ToShortDateString()}");
            //    });

            //    // Eg: cites/cityid
            //    endpoints.Map("cities/{cityid:guid}", async context =>
            //    {
            //        // guid is hexadecimal number
            //        Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"])!);
            //        await context.Response.WriteAsync($"City infomation - {cityId}");
            //    });

            //    // Eg: sales-report/2030/apr
            //    endpoints.Map("sales-report/{year:int:min(1900)}/{month:months}", async context =>
            //    {
            //        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
            //        string? month = Convert.ToString(context.Request.RouteValues["month"]);
            //        if (month == "apr" || month == "jul" || month == "oct" || month == "jan")
            //        {
            //            await context.Response.WriteAsync($"sales report - {year} - {month}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync($"{month} is not allowed for sales report ");
            //        }
            //    });
            //});

            app.UseAuthorization();

            //app.MapRazorPages();

            //app.MapGet("/", () => "Hello World!");

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/", async context =>
                {
                    await context.Response.WriteAsync("Hello");
                });
            });

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync($"No route matched at {context.Request.Path}");
            //});

            app.Run();
        }


    }
}