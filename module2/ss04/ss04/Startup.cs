using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ss04.Config;
using ss04.Dto;
using ss04.Models;
using ss04.Repository;
using ss04.Repository.Impl;
using ss04.Services;
using System.Text;
using System.Text.Json.Serialization;

namespace ss04
{
    public class Startup
    {
        private readonly IConfigurationRoot _configrationRoot;
        public Startup(IConfigurationRoot configurationRoot)
        {
            _configrationRoot = configurationRoot;
            
        }
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            var value = _configrationRoot.GetValue<string>("BookStore");

            //services.AddControllers().AddJsonOptions(x =>
            //    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            services.AddDbContext<DbContextBookStore>(options =>
            {
                options.UseSqlServer(value);
            });
            services.AddAutoMapper(typeof(Program).Assembly);
             //private readonly IMapper _mapper;
            //Book book = _mapper.Map<Book>(bookDto);
            services.AddScoped<IBookRepository, BookRepositoryImpl>();
            services.AddScoped<ICategoryRepository, CategoryRepositoryImpl>();
            services.AddScoped<IAuthorRepository, AuthorRepositoryImpl>();
            services.AddScoped<IUserRepository, UserRepositoryImpl>();
            #region cors
            var allowedOrigin = _configrationRoot.GetSection("AllowedOrigins").Get<string[]>();

            // Add services to the container.
            services.AddCors(options =>
            {
                options.AddPolicy("myAppCors", policy =>
                {
                    policy.WithOrigins(allowedOrigin)
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                });
            });
            #endregion

            #region jwt
            services.Configure<AppSetting>(_configrationRoot.GetSection(nameof(AppSetting)));
            
            var secretKey = _configrationRoot["AppSetting:SecretKey"];
            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        //tự cấp token
                        ValidateIssuer = false,
                        ValidateAudience = false,

                        //ký vào token
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes),

                        ClockSkew = TimeSpan.Zero
                    };
                });

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy(IdentityData.AdminUserPolicyName, p =>
            //        p.RequireClaim(IdentityData.AdminUserClaimName, "true"));
       
            //});
            #endregion





            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IWebHostEnvironment webHostEnvironment, WebApplication app)
        {
            if (webHostEnvironment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("myAppCors");
            app.UseHttpsRedirection();
            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

          

        }
    }
}
