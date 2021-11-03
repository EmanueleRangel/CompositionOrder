using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Order.Entities;

namespace Order.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            double subTotal = Quantity * Price;
            return subTotal;
        }

        public override string ToString()
        {
            return Product.Name 
                + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Quantity: " + Quantity 
                + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
