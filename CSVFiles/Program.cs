using CSVFiles.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CSVFiles {
    internal class Program {
        static void Main(string[] args) {
            // Create products
            List<Product> products = new List<Product>();
            products.Add(new Product("TV 4K", 1599.99, 1));
            products.Add(new Product("HSD SSD", 350.50, 3));
            products.Add(new Product("Motorola Z7", 2300.00, 2));
            products.Add(new Product("Tablet Samsung", 755.45, 4));
            products.Add(new Product("Pendrive Sandisk", 49.90, 5));

            // Create Entry CSV File
            string path = "E:\\Dev-Files\\C#";
            String sourceFile = $"{path}\\Products.csv";
            using (StreamWriter sw = new StreamWriter(sourceFile)) {
                foreach (Product prod in products) {
                    sw.WriteLine(prod.ProductTag(false));
                }
            }

            // Create Exit CSV File Updated
        }
    }
}
