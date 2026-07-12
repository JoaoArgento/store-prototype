using Catalog.Shared.ValueObjects;

namespace Catalog.Shared.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Category Category { get; private set; }

        public int Amount { get; private set; }

        public decimal Cost { get; private set; }

        public Product() { }

        public Product(string name, string description, Category category, int amount, decimal cost)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Amount = amount;
            Cost = cost;
        }
    }
}
