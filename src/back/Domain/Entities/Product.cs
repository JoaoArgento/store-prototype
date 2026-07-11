using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public int Amount { get; private set; }

        public Product() { }

        public Product(string name, string description, int amount)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Amount = amount;
        }

        public void AddAmount(int value)
        {
            if (value <= 0) throw new ArgumentException("the argument value should be greater than 0");

            Amount += value;
        }

        public void RemoveAmount(int value)
        {
            if (value <= 0) throw new ArgumentException("the argument value should be greater than 0");

            if (Amount - value < 0) throw new InvalidOperationException("there's no item available");

            Amount -= value;
        }
    }
}
