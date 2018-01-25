using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Fisher.Bookstore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Home",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "About",
                    template: "{controller=About}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "History",
                    template: "{controller=About}/{action=History}/{id?}");
                routes.MapRoute(
                    name: "Location",
                    template: "{controller=About}/{action=Location}/{id?}");
                routes.MapRoute(
                    name: "Books",
                    template: "{controller=Books}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "New",
                    template: "{controller=Books}/{action=New}/{id?}");
                routes.MapRoute(
                    name: "Authors",
                    template: "{controller=Authors}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "Featured",
                    template: "{controller=Authors}/{action=Featured}/{id?}");
                routes.MapRoute(
                    name: "Products",
                    template: "{controller=Offerings}/{action=Products}/{id?}");
                routes.MapRoute(
                    name: "Services",
                    template: "{controller=Offerings}/{action=Services}/{id?}");
            });
        }
    }
}
