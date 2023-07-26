using System.Data.Common;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Customer
    {
        public CustomerId Id {get; private set;}
        public string Name {get; private set;}

        public string Email {get; private set;}
    }
}