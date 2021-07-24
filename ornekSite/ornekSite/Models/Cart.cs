using ornekSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ornekSite.Models
{
    public class Cart
    {
        private List<Cartline> _cartlines = new List<Cartline>();
        public List<Cartline> CartLines
        {
            get { return _cartlines; }
        }
        public void AddProduct(Product product, int quantity)
        {
            var line = _cartlines.FirstOrDefault(i => i.Product.Id == product.Id);
            if(line==null)
            {
                _cartlines.Add(new Cartline() { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity = quantity;
            }
        }
        public void DeleteProduct(Product product)
        {
            _cartlines.RemoveAll(i => i.Product.Id == product.Id);
        }
        public double Total()
        {
            return _cartlines.Sum(i => i.Product.Price * i.Quantity);
        }
        public void Clear()
        {
            _cartlines.Clear();
        }
    }
    public class Cartline
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}