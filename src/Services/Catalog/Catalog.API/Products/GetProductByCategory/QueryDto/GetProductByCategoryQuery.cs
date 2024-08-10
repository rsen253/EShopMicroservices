namespace Catalog.API.Products.GetProductByCategory.QueryDto;

public sealed record GetProductByCategoryQuery(string Category)
    : IQuery<GetProductByCategoryResult>;
