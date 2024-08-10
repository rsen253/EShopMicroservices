namespace Catalog.API.Products.GetProductByCategory.QueryDto;

public sealed record GetProductByCategoryResult(IEnumerable<Product> Products);