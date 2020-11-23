using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Data;
using ProductCatalog.Repositories;

namespace ProductCatalog
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
      //Se tiver uma StoreDataContext na memoria, eu não preciso criar uma nova
      services.AddScoped<StoreDataContext, StoreDataContext>();

      //Abrir sempre uma nova ProductRepositorie(Essa classe chama a StoreDataContext)
      services.AddTransient<ProductRepository, ProductRepository>();
      
      
      
      
      
      
      
      
      //Se tiver uma StoreDataContext na memoria, eu crio uma nova
      //services.AddTransient<StoreDataContext, StoreDataContext>();
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseMvc();

      //app.Run(async (context) =>
      //{
      //  await context.Response.WriteAsync("Hello World!");
      //});
    }
  }
}
