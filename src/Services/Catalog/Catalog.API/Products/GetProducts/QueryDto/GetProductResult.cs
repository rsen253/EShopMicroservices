namespace Catalog.API.Products.GetProducts.QueryDto;

public sealed record GetProductResult(IEnumerable<Product> Products);