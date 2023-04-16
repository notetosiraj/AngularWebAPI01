

using CRM01.BusinessLayer;
using CRM01.Core;
using CRM01.Persistence;
using CRM01.Persistence.Repository;
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
            // services.AddRazorPages();  //as of not required 
            services.AddControllersWithViews();//it says register services for controller with views
            services.AddControllers(); //it says register services for api
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            string? connectionString = Configuration.GetConnectionString("default");
            services.AddDbContext<CRMDbContext>(DBContextOptionsBuilder => DBContextOptionsBuilder.UseSqlServer(connectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IServiceone, Serviceone>();

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
            else
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                //app.UseSwaggerUI(options =>
                //{  not required as of now 
                //    options.SwaggerEndpoint("./swagger/v1/swagger.json", "v1");
                //    options.RoutePrefix = string.Empty;
                //});
            }
         



            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            //not required
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html"); ;

            app.Run();

        }
    }

}
