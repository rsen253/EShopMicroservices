namespace Catalog.API.Products.GetProductByCategory.RequestDto;

public sealed record GetProductByCategoryResponse(IEnumerable<Product> Products);
