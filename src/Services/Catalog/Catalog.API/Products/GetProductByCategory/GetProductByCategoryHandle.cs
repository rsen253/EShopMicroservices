﻿using Catalog.API.Products.GetProductByCategory.QueryDto;

namespace Catalog.API.Products.GetProductByCategory;

public class GetProductByCategoryHandle(IDocumentSession session, ILogger<GetProductByCategoryHandle> logger)
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
