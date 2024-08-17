
#region nuget packages

global using Carter;
global using Mapster;
global using MediatR;
global using Marten;
global using Marten.Pagination;
global using FluentValidation;
global using HealthChecks.UI.Client;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Marten.Schema;

#endregion

#region Application name-spaces

global using BuildingBlocks.Behaviors;
global using BuildingBlocks.CQRS;
global using BuildingBlocks.Exceptions.Handler;
global using Catalog.API.Models;
global using Catalog.API.Products.CreateProduct.CommandDto;
global using Catalog.API.Products.CreateProduct.RequestDto;
global using Catalog.API.Products.GetProducts.QueryDto;
global using Catalog.API.Products.GetProducts.RequestDto;
global using Catalog.API.Exceptions;
global using Catalog.API.Products.GetProductById.QueryDto;
global using Catalog.API.Products.GetProductById.RequestDto;
global using Catalog.API.Products.GetProductByCategory.QueryDto;
global using Catalog.API.Products.GetProductByCategory.RequestDto;
global using Catalog.API.Products.DeleteProduct.CommandDto;
global using Catalog.API.Products.DeleteProduct.RequestDto;
global using Catalog.API.Products.UpdateProduct.CommandDto;
global using Catalog.API.Products.UpdateProduct.RequestDto;
global using BuildingBlocks.Exceptions;

#endregion