using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IRepositories;
using ClassLibrary1.Interfaces.IServices;
using ClassLibrary1.Repositories;
using ClassLibrary1.Services;
using ClassLibrary1.UnitOfWork;
using ClassLibrary2;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApplicationEF
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            #region  repositories
            services.AddTransient<IReservationRepository, ReservationRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITypesOfTourRepository, TypesOfTourRepository>();
            services.AddTransient<ITypesOfTransportRepository, TypesOfTransportRepository>();
            #endregion

            #region  services

            services.AddTransient<IReservationService, ReservationService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITypesOfTourService, TypesOfTourService>();
            services.AddTransient<ITypesOfTransportService, TypesOfTransportService>();

            #endregion

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ApplicationContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
