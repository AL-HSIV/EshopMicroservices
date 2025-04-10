using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record  CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price ):IRequest<CreateProductResult>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
    public record CreateProductResult(Guid Id);
  
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // Simulate product creation
            var productId = Guid.NewGuid();
            return Task.FromResult(new CreateProductResult(productId));
        }
    }
  
}
