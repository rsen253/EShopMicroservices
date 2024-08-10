namespace Catalog.API.Products.DeleteProduct.CommandDto;

public record DeleteProductCommand(Guid Id) : ICommand<DeleteProductResult>;