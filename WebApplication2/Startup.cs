using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces.IServices;
using BLL.Mapping;
using BLL.Services;
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IRepositories;
using ClassLibrary1.Interfaces.IServices;
using ClassLibrary1.Repositories;
using ClassLibrary1.Services;
using ClassLibrary1.UnitOfWork;
using ClassLibrary2;
using DAL;
using DAL.Interfaces.IRepositories;
using DAL.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace WebApplication2
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
            services.Configure<ApplicationSettings>(Configuration.GetSection("ApplicationSettings"));
            services.AddControllersWithViews();
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

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            });

            //Jwt Auth

            var key = Encoding.UTF8.GetBytes(Configuration["ApplicationSettings:JWT_Secret"].ToString());

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = false;
                x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
