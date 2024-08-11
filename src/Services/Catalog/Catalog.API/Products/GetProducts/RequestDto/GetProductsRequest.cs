namespace Catalog.API.Products.GetProducts.RequestDto;

public sealed record GetProductsRequest(int? PageNumber = 1, int? PageSize = 10);
