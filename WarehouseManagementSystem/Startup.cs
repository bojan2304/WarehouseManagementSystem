using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Services.Providers;

namespace WarehouseManagementSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<IWarehouseAssetService, WarehouseAssetService>();
            services.AddScoped<ICheckoutService, CheckoutService>();
            services.AddScoped<IToolService, ToolService>();
            services.AddScoped<IWarehouseBranchService, WarehouseBranchService>();
            services.AddScoped<IWarehouseEmployeeCardService, WarehouseEmployeeCardService>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddDbContext<WmsContext>(options 
                => options.UseSqlServer(Configuration.GetConnectionString("WmsDatabase")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
