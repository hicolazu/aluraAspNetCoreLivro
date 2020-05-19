using Alura.ListaLeitura.App.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        // Configura a aplicação para utilizar o serviço de roteamento do ASP Net Core
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
            services.AddMvc();
        }

        /**
         * Para configurar para ambientes diferentes, temos os métodos:
         * ConfigureDevelopment() -> ambiente de desenvolvimento
         * ConfigureProduction() -> ambiente de produção
         * ConfigureStaging() -> ambiente de testes
         * Também podemos criar classes Startup diferentes para cada ambiente:
         * StartupDevelopment
         * StartupProduction
         * StartupStaging
         */
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
        }
    }
}