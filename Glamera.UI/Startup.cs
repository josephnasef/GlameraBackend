using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Glamera.Domin.Context;
using Glamera.Services.Abstraction;
using Glamera.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Glamera.Domin.Models;
using Glamera.DTO.MappingConfigurations;
using Glamera.DTO.configuration;
using Glamera.UI.Middleware;
using Glamera.Repository.Abstraction;
using Glamera.Repository.Mangers;
//using Glamera.UI.Authorization;

namespace Glamera.UI
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
            services.AddAutoMapper(typeof(UserProfile));
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            services.Configure<JwtConfig>(Configuration.GetSection("JwtConfig"));
            services.AddDbContext<GlameraContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<GlameraContext>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options => options.ClaimsIdentity.UserIdClaimType = ClaimTypes.NameIdentifier);
            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
            //repositories
            services.AddScoped<IitemRepo, ItemRepo>();
            services.AddScoped<IApplicationUserRepo, ApplicationUserRepo>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<IBranchRepo, BranchRepo>();
            services.AddScoped<IitemBranchRepo, ItemBranchRepo>();
            services.AddScoped<IBillRepo, BillRepo>();
            //service
            services.AddScoped<IBillService, BillService>();
            services.AddScoped<IUserMangementService, UserMangementService>();
            services.AddScoped<BranchService, BranchService>();
            services.AddScoped<CategoryService, CategoryService>();
            services.AddScoped<IitemBranchService, ItemBranchService>();
            services.AddScoped<IBillService, BillService>();
            //services.AddScoped<IJwtUtils, JwtUtils>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Glamera.UI", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Glamera.UI v1"));
            }

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseRouting();
            //app.UseAuthorization();
            //app.UseAuthentication();
            //app.UseMiddleware<JwtMiddleware>();
            app.UseMiddleware<ErrorHandlerMiddleware>();
            app.UseEndpoints(x => x.MapControllers());
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
