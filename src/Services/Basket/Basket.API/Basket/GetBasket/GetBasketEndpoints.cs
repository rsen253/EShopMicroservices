﻿namespace Basket.API.Basket.GetBasket;

// public record GetBasketRequest(string UserName)
public record GetBasketResponse(ShoppingCart ShoppingCart);

public class GetBasketEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/basket/{userName}", async (string userName, ISender sender) =>
        {
            var result = sender.Send(new GetBasketQuery(userName));
            return Results.Ok(result.Adapt<GetBasketResponse>());
        })
        .WithName("GetProductById")
        .Produces<GetBasketResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Get Product By Id")
        .WithDescription("Get Product By Id");
    }
}
