using Core.Security.EmailAuthenticator;
using Core.Security.Interfaces.EmailAuthenticator;
using Core.Security.Interfaces.IOtpAuthenticator;
using Core.Security.Interfaces.JWT;
using Core.Security.JWT;
using Core.Security.OptAuthenticator;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Security
{
    public static class SecurityServiceRegistration
    {
        public static IServiceCollection AddSecurityServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenHelper, JwtHelper>();
            services.AddScoped<IEmailAuthenticatorHelper, EmailAuthenticatorHelper>();
            services.AddScoped<IOtpAuthenticatorHelper, OtpAuthenticatorHelper>();
            return services;
        }
    }
}