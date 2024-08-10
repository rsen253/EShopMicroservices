namespace Catalog.API.Products.UpdateProduct.CommandDto;

public sealed record UpdateProductCommand(Guid Id, 
    string Name, List<string> Category, 
    string Description, string ImageFile, decimal Price)
    : ICommand<UpdateProductResult>;
