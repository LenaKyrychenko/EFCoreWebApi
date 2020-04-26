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
using AutoMapper;
using DAL.Interfaces.IRepositories;
using DAL.Repositories;
using BLL.Interfaces.IServices;
using BLL.Services;
using BLL.Mapping;
using ClassLibrary1.Entities;
using Microsoft.AspNetCore.Identity;

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
            services.AddAutoMapper(typeof(UserMap));
            services.AddAutoMapper(typeof(TypesOfTourMap));
            services.AddAutoMapper(typeof(TypesOfTransportMap));
            services.AddAutoMapper(typeof(TourMap));
            services.AddAutoMapper(typeof(ReservationMap));
            services.AddControllersWithViews();
            #region  repositories
            services.AddTransient<IReservationRepository, ReservationRepository>();
            services.AddTransient<ITypesOfTourRepository, TypesOfTourRepository>();
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();
            services.AddTransient<ITypesOfTransportRepository, TypesOfTransportRepository>();
            services.AddTransient<ITourRepository, TourRepository>();
            #endregion

            #region  services

            services.AddTransient<IReservationService, ReservationService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITypesOfTourService, TypesOfTourService>();
            services.AddTransient<ITypesOfTransportService, TypesOfTransportService>();
            services.AddTransient<ITourService, TourService>();

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
