using AutoMapper;
using Catalog.Shared.Entities;
using Catalog.Shared.Infra;
using Catalog.Shared.Models;
using MediatR;

namespace Catalog.Features.CreateProduct
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductModel>
    {
        private readonly ProductDbContext productDbContext;
        private readonly IMapper mapper;
        public CreateProductHandler(ProductDbContext productDbContext, IMapper mapper)
        {
            this.productDbContext = productDbContext;
            this.mapper = mapper;
        }

        public async Task<ProductModel> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new Product(request.Name, request.Description, request.Category, request.Amount, request.Cost);
            await productDbContext.AddAsync(product, cancellationToken);
            await productDbContext.SaveChangesAsync(cancellationToken);

            return mapper.Map<ProductModel>(product);
        }
    }

}
