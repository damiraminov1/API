using Domain.Contexts;
using Domain.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace CalcMicroservice
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddCors();
			builder.Services.AddAuthorization();
			builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddJwtBearer(options =>
				{
					options.TokenValidationParameters = new TokenValidationParameters
					{
						// ���������, ����� �� �������������� �������� ��� ��������� ������
						ValidateIssuer = true,
						// ������, �������������� ��������
						ValidIssuer = AuthOptions.ISSUER,
						// ����� �� �������������� ����������� ������
						ValidateAudience = true,
						// ��������� ����������� ������
						ValidAudience = AuthOptions.AUDIENCE,
						// ����� �� �������������� ����� �������������
						ValidateLifetime = true,
						// ��������� ����� ������������
						IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
						// ��������� ����� ������������
						ValidateIssuerSigningKey = true,
					};
				});
			builder.Services.AddDbContext<ApplicationContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c => {
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    BearerFormat = "JWT",
                    Name = "JWT Authentication",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };

                c.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecurityScheme, Array.Empty<string>() }
    });
            });

            var app = builder.Build();

			// Configure the HTTP request pipeline.
			app.UseCors(x => x
				.AllowAnyMethod()
				.AllowAnyHeader()
				.AllowAnyOrigin()
			);
			
			app.UseSwagger();
			app.UseSwaggerUI(
					options =>
				{
					options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
					options.RoutePrefix = string.Empty;
				}
			);

			//app.UseHttpsRedirection();
			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}