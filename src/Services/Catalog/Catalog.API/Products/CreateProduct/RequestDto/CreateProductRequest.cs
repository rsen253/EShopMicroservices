namespace Catalog.API.Products.CreateProduct.RequestDto;

public sealed record CreateProductRequest(string Name, List<string> Category,
    string Description, string ImageFile, decimal Price);
