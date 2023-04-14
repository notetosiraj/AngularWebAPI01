

using CRM01.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace CRM01
{
    //This file wont be available in NET 6 we adding this for register services and middleware purpose 
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; set; }
    
        /// <summary>
        /// This is place Middleware configure
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            string? connectionString = Configuration.GetConnectionString("default");
            services.AddDbContext<CRMDbContext>(DBContextOptionsBuilder => DBContextOptionsBuilder.UseSqlServer(connectionString));

        }

        /// <summary>
        /// This place where to we register services dependency DI
        /// </summary>
        public void Configure(WebApplication app,IHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }



            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html"); ;

            app.Run();

        }
    }

}
