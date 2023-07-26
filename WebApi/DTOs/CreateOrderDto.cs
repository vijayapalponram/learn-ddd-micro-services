using System;
using System.Collections.Generic;
using Domain.ValueObjects;

namespace WebApi.DTOs
{
    public class CreateOrderDto
    {
        public Guid CustomerId {get; set;}
        public List<Product> Products {get; set;}
    }

    public class Product{
      public Guid ProductId {get; set;}
      public Double Price {get; set;}
      public string Currency { get; set;}
    }
}