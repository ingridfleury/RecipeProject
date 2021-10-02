using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using RecipeProject.Application.Contracts;
using RecipeProject.Application.Services;
using RecipeProject.Infra.IoC;
using System.Text;

namespace RecipeProject.WebApi
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // add authorization

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    // Tell authorization how to validate the token
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        // Validate the issuer signing key (our API is going to sign the token)
                        ValidateIssuerSigningKey = true,
                        // How was it signed
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["TokenKey"])),
                        ValidateIssuer = false, // Issuer: API Server
                        ValidateAudience = false // Audience: Angular Application
                    };
                });

            services.AddApiConfigurations(_config);

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RecipeProject.WebAPI", Version = "v1" });
            });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RecipeWeb.Services.WebAPI v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(x => { x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); });

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
