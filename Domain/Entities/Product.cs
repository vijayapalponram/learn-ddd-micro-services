using System.Data.Common;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Product
    {
        public ProductId Id { get; private set; }
        public string Name { get; private set;} = String.Empty;
        public Money Price { get; private set;}

    }
}