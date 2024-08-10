
using Catalog.API.Products.GetProductByCategory.QueryDto;
using Catalog.API.Products.GetProductByCategory.RequestDto;

namespace Catalog.API.Products.GetProductByCategory
{
    public class GetProductByCategoryEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/products/category/{categoryId}", async (string categoryId, ISender sender) =>
            {
                var result = await sender.Send(new GetProductByCategoryQuery(categoryId));
                return Results.Ok(result.Adapt<GetProductByCategoryResponse>());
            })
            .WithName("GetProductByCategory")
            .Produces<GetProductByCategoryResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Get Product By Category")
            .WithDescription("Get Product By Category");
        }
    }
}
