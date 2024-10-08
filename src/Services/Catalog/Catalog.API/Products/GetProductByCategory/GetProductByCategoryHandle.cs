﻿
namespace Catalog.API.Products.GetProductByCategory;

internal class GetProductByCategoryHandle(IDocumentSession session)
    : IQueryHandler<GetProductByCategoryQuery, GetProductByCategoryResult>
{
    public async Task<GetProductByCategoryResult> Handle(GetProductByCategoryQuery query, CancellationToken cancellationToken)
    {
        var result = await session.Query<Product>()
                    .Where(x => x.Category.Contains(query.Category))
                    .ToListAsync(cancellationToken);
        return new GetProductByCategoryResult(result);
    }
}
