using Catalog.Features.CreateProduct;
using MediatR;

namespace e_commerce_backend
{
    public static class ProductsEndpoints
    {
        public static void MapProductEndpoints(this IEndpointRouteBuilder app)
        {
            RouteGroupBuilder group = app.MapGroup("/api/products").WithTags("Products");

            group.MapPost("/", async (CreateProductCommand createProductCommand, IMediator mediator) =>
            {
                var result = mediator.Send(createProductCommand);
                return Results.Created($"api/products/{result.Id}", result);
            });

        }
    }
}
