using ChallengeSandino.Models;
using ChallengeSandino.Providers;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;

namespace ChallengeSandino
{
    public partial class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /*public void ConfigurationServices(IServiceCollection services)
        {
            services.AddDbContextPool<FinancesChallengeDBEntities1>(
                options => options.UseSqlServer(_configuration.GetConnectionString("FinancesChallengeDBEntities1")));
        }*/

        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        // Para obtener más información sobre cómo configurar la autenticación, visite https://go.microsoft.com/fwlink/?LinkId=301864 
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure el contexto de base de datos y el administrador de usuarios para usar una única instancia por solicitud
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            // Permitir que la aplicación use una cookie para almacenar información para el usuario que inicia sesión
            // y una cookie para almacenar temporalmente información sobre un usuario que inicia sesión con un proveedor de inicio de sesión de terceros
            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Configure la aplicación para el flujo basado en OAuth
            PublicClientId = "self";
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/Token"),
                Provider = new ApplicationOAuthProvider(PublicClientId),
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(1),
                // En el modo de producción establezca AllowInsecureHttp = false
                AllowInsecureHttp = true
            };

            // Permitir que la aplicación use tokens portadores para autenticar usuarios
            app.UseOAuthBearerTokens(OAuthOptions);            
        }
    }
}
