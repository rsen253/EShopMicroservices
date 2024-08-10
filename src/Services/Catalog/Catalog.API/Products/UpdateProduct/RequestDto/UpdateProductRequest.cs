namespace Catalog.API.Products.UpdateProduct.RequestDto;

public sealed record UpdateProductRequest(Guid Id, string Name, List<string> Category, string Description, string ImageFile, decimal Price);