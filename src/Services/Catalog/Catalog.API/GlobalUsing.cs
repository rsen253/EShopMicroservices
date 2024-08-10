﻿
#region nuget packages

global using Carter;
global using Mapster;
global using MediatR;
global using Marten;

#endregion

#region Application name-spaces

global using BuildingBlocks.CQRS;
global using Catalog.API.Models;
global using Catalog.API.Products.CreateProduct.CommandDto;
global using Catalog.API.Products.CreateProduct.RequestDto;
global using Catalog.API.Products.GetProducts.QueryDto;
global using Catalog.API.Products.GetProducts.RequestDto;
global using Catalog.API.Exceptions;
global using Catalog.API.Products.GetProductById.QueryDto;
global using Catalog.API.Products.GetProductById.RequestDto;

#endregion