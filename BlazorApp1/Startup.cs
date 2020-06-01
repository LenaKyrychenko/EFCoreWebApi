using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorApp1.Data;
using AutoMapper;
using BLL.Mapping;
using ClassLibrary1.Interfaces.IRepositories;
using ClassLibrary1.Repositories;
using Microsoft.AspNetCore.Identity;
using ClassLibrary1.Entities;
using ClassLibrary2;
using DAL.Interfaces.IRepositories;
using DAL.Repositories;
using ClassLibrary1.Interfaces.IServices;
using ClassLibrary1.Services;
using BLL.Interfaces.IServices;
using BLL.Services;
using ClassLibrary1.Interfaces;
using ClassLibrary1.UnitOfWork;
using FluentValidation;
using BlazorApp1.Validators;

namespace BlazorApp1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            //services.AddControllersWithViews();
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

            services.AddValidatorsFromAssemblyContaining<RegisterViewModelValidator>();
            //services.AddValidatorsFromAssemblyContaining<LoginViewModelValidator>();

            services.AddHttpClient<Services.TourService>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:49397");
            });

            services.AddHttpClient<Services.AccountService>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:49397");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
