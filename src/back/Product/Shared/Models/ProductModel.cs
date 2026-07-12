using Catalog.Shared.ValueObjects;

namespace Catalog.Shared.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public decimal Cost { get; set; }
        public int Amount { get; set; }

        public ProductModel() { }

    }
}
