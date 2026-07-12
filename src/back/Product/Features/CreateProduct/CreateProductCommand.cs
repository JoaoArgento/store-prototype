using Catalog.Shared.Models;
using Catalog.Shared.ValueObjects;
using MediatR;

namespace Catalog.Features.CreateProduct
{
    public record CreateProductCommand(string Name, string Description, Category
        Category, decimal Cost, int Amount) : IRequest<ProductModel>;
}
