using OperationOOP.Api.Endpoints;
using OperationOOP.Core.Data;
using Microsoft.Extensions.Options;

namespace OperationOOP.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddAuthorization();

            // Lägg till Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.CustomSchemaIds(type => type.FullName?.Replace('+', '.'));
                options.InferSecuritySchemes();
            });

            // Lägg till en databas-instans
            builder.Services.AddSingleton<IDatabase, Database>();

            var app = builder.Build();

            // Aktivera Swagger om vi är i utvecklingsläge
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

            // Registrera endpoints från PlantEndpoints
            PlantEndpoints.MapGetEndpoint(app); // Registrera GET endpoint
            PlantEndpoints.MapPostEndpoint(app); // Registrera POST endpoint

            app.Run();
        }
    }
}
