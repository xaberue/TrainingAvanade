using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Training.Application.Books;
using Training.Application.Reservations;
using Training.Core.Repositories;
using Training.DAL;
using Training.WebAPI.Helpers;

namespace Training.WebAPI
{
    public class Startup
    {

        private const string AUTH_SCHEMA = "BasicAuthentication";


        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(loggingBuilder => {
                loggingBuilder.AddFile("app.log", append: true);
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Training.WebAPI", Version = "v1" });
            });

            services.AddAuthentication(AUTH_SCHEMA)
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>(AUTH_SCHEMA, null);

            services.AddTransient<ICustomDateTimeProvider, CustomDateTimeProvider>();
            services.AddTransient<IBookService, BookService>();
            services.AddSingleton<IBookRepository, BookRepository>();
            services.AddTransient<IReservationService, ReservationService>();
            services.AddSingleton<IReservationRepository, ReservationRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();

            services.AddScoped<ClientActionInvokedMiddleware>();
            services.AddScoped<RequestCultureMiddleware>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Training.WebAPI v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseMiddleware<ClientActionInvokedMiddleware>();
            app.UseMiddleware<RequestCultureMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
