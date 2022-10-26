using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shop.Core.Data;
using System;
using System.Configuration;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Shop.Core
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShopDbContext>(options =>
            {
                options.UseSqlServer(ConfigurationManager.ConnectionStrings["ShopDbConnectionString"].ConnectionString);
            });
        }
    }
}
