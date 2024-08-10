
namespace Catalog.API.Products.CreateProduct;

internal class CreateProductHandler(IDocumentSession session) 
    : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //create product entity form incoming command object
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        //save to database
        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);

        //return the CreateProductResult
        return new CreateProductResult(product.Id);
    }
}