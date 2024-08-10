
namespace Catalog.API.Products.GetProducts;

internal class GetProductsQueryHandler(IDocumentSession session, ILogger<GetProductsQueryHandler> logger)
    : IQueryHandler<GetProductsQuery, GetProductResult>
{
    public async Task<GetProductResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetProductsQueryHandler.Handle called with {@Query}", query);
        var products = await session.Query<Product>().ToListAsync(cancellationToken);
        return new GetProductResult(products);

    }
}