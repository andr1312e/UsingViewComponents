﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingViewComponents.Models
{
    public interface IProductRepository 
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product product);
    }
    public class ProductRepository:IProductRepository
    {
     private List<Product> products = new List<Product>{
                new Product{Name="Kayak", Price=275M},
                new Product{Name="Lifejacket", Price=28.95M},
                new Product{Name="Soccer Ball", Price=444M}
            };
        public IEnumerable<Product> Products => products;
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
