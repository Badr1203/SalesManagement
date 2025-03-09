using Sales_Management.View;
using Sales_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sales_Management.Model
{
    public class Product
    {
        private int id;
        private string name;
        private double price;
        private int quantity;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public double TotalPrice => Price * Quantity;

        public Product(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product otherProduct)
            {
                return this.Id == otherProduct.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
