using albinasHotelGuide.Business.Abstract;
using albinasHotelGuide.Business.Concrete;
using albinasHotelGuide.WebMVC.Helpers.Abstract;
using albinasHotelGuide.WebMVC.Helpers.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace albinasHotelGuide.WebMVC.Configurations
{
    public class ConfigureDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationManager>();

            services.AddTransient<IUserAccessor, UserAccessor>();
            services.AddTransient<IFileHelper, FileHelper>();


        }



    }
}
