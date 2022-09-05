using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFiles.Entities {
    public class Product {
        // Attributes
        public string Name { get; set; }
        public double Price { get; set; }
        
        public int Quantity { get; set; }
        
        // Constructors
        public Product() {}

        public Product(string name, double price, int quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Methods
        public double TotalValue() {
            return Quantity * Price;
        }

        public string ProductTag(bool totalize) {
            string tag = $"{Name};";
            if (!totalize) { 
                tag += $"{Price.ToString("F2", CultureInfo.InvariantCulture)};{Quantity}";
            } else {
                tag += $"{TotalValue().ToString("F2", CultureInfo.InvariantCulture)}";
            }
            return tag;
        }
    }
}
