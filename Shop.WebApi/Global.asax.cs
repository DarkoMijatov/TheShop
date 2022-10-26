using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shop.Core.Data;
using System.Configuration;
using System.Web.Http;
using System.Web.Mvc;

namespace Shop.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShopDbContext>(options =>
            {
                options.UseSqlServer(ConfigurationManager.ConnectionStrings["ShopDbConnectionString"].ConnectionString);
            });
        }
    }
}
