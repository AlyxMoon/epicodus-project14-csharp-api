using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MyApi.Models;
using MyApi.Models.Database;

namespace MyApi
{
  public class Startup
  {
    public Startup(IWebHostEnvironment env)
    {
      IConfigurationBuilder builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json");
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();

      services.AddSingleton<IConfiguration>(Configuration);

      string connection = Configuration["ConnectionStrings:DefaultConnection"];
      ServerVersion version = ServerVersion.AutoDetect(connection);

      services
        .AddEntityFrameworkMySql()
        .AddDbContext<DatabaseContext>(options => options.UseMySql(
          connection, 
          version
        ));

      services
        .AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<DatabaseContext>()
        .AddDefaultTokenProviders();

      services
        .AddAuthentication(options =>  {  
          options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;  
          options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;  
          options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;  
        })
        .AddJwtBearer(options => {  
            options.SaveToken = true;  
            options.RequireHttpsMetadata = false;  
            options.TokenValidationParameters = new TokenValidationParameters () {  
              ValidateIssuer = false,  
              ValidateAudience = false,   
              IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))  
            };  
        });  

      services.Configure<IdentityOptions>(options =>
      {
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 8;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredUniqueChars = 0;
      });
    }

    public void Configure(IApplicationBuilder app)
    {
      app
        .UseAuthentication()
        .UseStaticFiles()
        .UseDeveloperExceptionPage()
        .UseRouting()
        .UseAuthorization()
        .UseEndpoints(routes =>
        {
          routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
        })
        .Run(async (context) =>
        {
          await context.Response.WriteAsync("Route not found!");
        });
    }
  }
}