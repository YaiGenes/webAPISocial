using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using VY.SocialMedia.Business.Implementation.Mappings;
using VY.SocialMedia.Business.Implementation.Validations;
using VY.SocialMedia.Data.Contracts.Interfaces;
using VY.SocialMedia.Data.Implementation.Data;
using VY.SocialMedia.Data.Implementation.Repositories;

namespace VY.SocialMedia.AppWebApi
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
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(typeof(AutomapperProfile));
            //automapper to transform from entities to dtos
            services.AddControllers().AddNewtonsoftJson(opt =>
                opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            //to avoid looping reference on api request
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddDbContext<SocialMediaContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("SocialMedia"))
            );
            //add global request validation
            services.AddMvc(opt =>
            {
                opt.Filters.Add<ValidationFilter>();
            }).AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            });
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
