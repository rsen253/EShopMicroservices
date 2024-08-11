
namespace Catalog.API.Products.GetProducts;

internal class GetProductsQueryHandler(IDocumentSession session)
    : IQueryHandler<GetProductsQuery, GetProductResult>
{
    public async Task<GetProductResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        var products = await session.Query<Product>().AsQueryable()
            .ToPagedListAsync(query.PageNumber ?? 1, query.PageNumber ?? 10, cancellationToken);
        return new GetProductResult(products);

    }
}