using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PallidaWareHouse.Entities;
using Microsoft.EntityFrameworkCore;
using PallidaWareHouse.Repositories;

namespace PallidaWareHouse
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ClothesContext>(options =>
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=clothes;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddScoped<ClothingRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
