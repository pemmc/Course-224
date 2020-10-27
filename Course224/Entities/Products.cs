using System;
using System.Globalization;

namespace Course224.Entities
{
    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;

        }

        public override string ToString()
        {
            return "Nome: "
                    + Name
                    + ", | Preço: "
                    + Price.ToString("C", new CultureInfo("pt-BR"));
        }

    }



}
