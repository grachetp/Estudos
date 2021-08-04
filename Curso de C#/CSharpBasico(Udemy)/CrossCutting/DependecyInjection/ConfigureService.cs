using Domain.Interfaces.Services.User;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace CrossCutting.DependecyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
        /*
            Transient -> Pra cada vez que tiver uma injeção de dependencia, sempre cria uma nova instancia quando for utilizar.
            Scoped -> Se em dez métodos precisar usar esse mesmo IUserService, sempre vai utilizar a mesma instancia UserService.
            Singleton -> iniciou a aplicação nunca mais vai mudar essa instancia
        */
            serviceCollection.AddTransient<IUserService, UserService>();
        }
    }
}
