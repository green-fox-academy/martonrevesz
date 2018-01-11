using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AnagramApp.Models;

namespace AnagramApp
{
    public class Startup
    {
         public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<AnagramChecker>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
