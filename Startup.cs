using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
 
namespace aspnetcoreapp
{
    public class Startup
    { 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
 
        public void Configure(IApplicationBuilder app)
        { 
            app.UseMvc(routes =>
					{
					    routes.MapRoute(
					        name: "default",
					        template: "{controller=Home}/{action=Index}/{id?}");
					});
        }
    }
}