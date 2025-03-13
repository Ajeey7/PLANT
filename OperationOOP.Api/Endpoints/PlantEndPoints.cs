using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OperationOOP.Core.Data;
using OperationOOP.Core.Models;

namespace OperationOOP.Api.Endpoints
{
    public static class PlantEndpoints
    {
      
        public static void MapGetEndpoint(IEndpointRouteBuilder app) => app
            .MapGet("/plants", (IDatabase db) =>
            {
                return Results.Ok(db.Plants);
            });

     
        public static void MapPostEndpoint(IEndpointRouteBuilder app) => app
            .MapPost("/plants", (IDatabase db, Plant plant) =>
            {
                plant.Id = db.Plants.Count + 1;
                db.Plants.Add(plant);
                return Results.Created($"/api/plants/{plant.Id}", plant);
            });
    }
}