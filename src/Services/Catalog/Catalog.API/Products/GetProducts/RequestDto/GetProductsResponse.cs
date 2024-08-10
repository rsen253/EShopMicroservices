namespace Catalog.API.Products.GetProducts.RequestDto;

public sealed record GetProductsResponse(IEnumerable<Product> Products);