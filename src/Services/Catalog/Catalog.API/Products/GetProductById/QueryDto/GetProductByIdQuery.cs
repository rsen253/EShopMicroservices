namespace Catalog.API.Products.GetProductById.QueryDto;

public sealed record GetProductByIdQuery(Guid Id) 
    : IQuery<GetProductByIdResult>;