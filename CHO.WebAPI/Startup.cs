using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CHO.Business.Concrete;
using CHO.Business.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CHO.WebAPI
{
  public class Startup
  {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();

      //services.AddTransient<IClientManager, ClientService>();

      //services.AddScoped<IClientManager, ClientService>();

      services.AddSingleton<IClientManager, ClientService>();

      var serviceProvider = services.BuildServiceProvider();

      var service1 = serviceProvider.GetService<IClientManager>();
      var service2 = serviceProvider.GetService<IClientManager>();

      Console.WriteLine($"Nesne eþit mi? {service1 == service2}");


    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
