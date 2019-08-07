using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMM.Data;
using FactoryMM.Models.CompanyPurchaseMm;
using FactoryMM.Models.CustommerMm;
using FactoryMM.Models.EmployeeMm;
using FactoryMM.Models.InventoryMm.MaterialInventoryMm;
using FactoryMM.Models.InventoryMm.ProductInventoryMm;
using FactoryMM.Models.ProductionMM;
using FactoryMM.Models.SupplierMm;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMM
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContextPool<AppDbContext>(
                    options => options.UseSqlServer(_config.GetConnectionString("FactoryMMDBConnection")));


            services.AddIdentity<ApplicationUser, IdentityRole>(option =>
            {
                option.Password.RequiredLength = 8;
                option.Password.RequiredUniqueChars = 3;
                option.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<AppDbContext>();

            services.AddMvc(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                  .RequireAuthenticatedUser()
                                  .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            }).AddXmlSerializerFormatters();

            //services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
            services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();
            //services.AddSingleton<IProductInventoryRepository, MockProductInventoryRepository>();
            services.AddScoped<IProductInventoryRepository, SQLProductionInventoryRepository>();

            services.AddScoped<IMaterialInventoryRepository, SQLMaterialsInventoryRepository>();

            services.AddScoped<ICompanyPurchaseRepository, SQLCompanyPurchaseRepository>();

            services.AddScoped<IProductionRepository, SQLIProductionRepository>();

            services.AddScoped<ICustomerRepository, SQLCustomerRepository>();

            services.AddScoped<ISupplierRepository, SQLSupplierRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }

            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();

            app.UseAuthentication();

            //Conventional Routing
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
                // routes.MapRoute("default", "{controller=Employees}/{action=Index}/{id?}");
            });

        }
    }
}
