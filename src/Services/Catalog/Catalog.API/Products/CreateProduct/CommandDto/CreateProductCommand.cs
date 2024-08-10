
namespace Catalog.API.Products.CreateProduct.CommandDto;

public sealed record CreateProductCommand(string Name, List<string> Category,
    string Description, string ImageFile, decimal Price) : ICommand<CreateProductResult>;
