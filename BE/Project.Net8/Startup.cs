using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Project.Net8.Installers;

namespace Project.Net8;

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
        // NOTE: SSL and Build are called by the build-in services already.


        services.AddHttpContextAccessor();

        services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });
        services.AddControllers(
            x => x.AllowEmptyInputInBodyModelBinding = true
        ).AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            // options.SerializerSettings.Converters.Add(new TimeConvertExtenstion());
        });


        services.InstallServicesInAssembly(Configuration);
        services.AddControllers();
        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Project.Net8.WebAPI", Version = "v1" });
        });

        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithOrigins(
                        "http://localhost:8080",
                        "http://localhost:8081",
                        "http://localhost:8013",
                        "http://localhost:8014",
                        "http://127.0.0.1:5500",
                        "https://apitest.dongthap.gov.vn"
                    )
                    .AllowCredentials()
            );
        });

        services.Configure<IISServerOptions>(options => { options.MaxRequestBodySize = long.MaxValue; });

        services.Configure<KestrelServerOptions>(options =>
        {
            options.Limits.MaxRequestBodySize = long.MaxValue; // if don't set default value is: 30 MB
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.Use(async (context, next) =>
        {
            var culture = CultureInfo.CurrentCulture.Clone() as CultureInfo; // Set user culture here
            culture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;

            // Call the next delegate/middleware in the pipeline
            await next();
        });

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Project.Net8.WebAPI v1"));
        }

        app.UseHttpsRedirection();
        app.UseCors("CorsPolicy");
        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseStaticFiles();

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}