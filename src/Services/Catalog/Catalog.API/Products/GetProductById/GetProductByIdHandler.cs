
namespace Catalog.API.Products.GetProductById;

internal class GetProductByIdHandler(IDocumentSession session, ILogger<GetProductByIdHandler> logger)
    : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
{
    public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        var product = await session.LoadAsync<Product>(query.Id, cancellationToken);
        if(product == null)
        {
            throw new ProductNotFoundException();
        }
        return new GetProductByIdResult(product);
    }
}
