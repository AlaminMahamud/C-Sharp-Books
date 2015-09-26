// Automatically implemented properties and simpler initialization

using System.Collections.Generic;

public class Product
{
/*
    private string name;

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    private decimal price;

    public decimal Price
    {
        get { return price; }
        private set { price = value; }
    }
 */

    public string Name { get; private set; }
    public decimal Price { get; private set; }


    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    private Product()
    {
    
    }

    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product{Name = "West Side Story", Price = 9.99m},
            new Product{Name = "Assasins", Price = 14.99m},
            new Product{Name = "Frogs", Price = 13.99m},
            new Product{Name = "Sweeny Todd", Price = 10.99m}
        };
    }

    public override string ToString()
    {
        return String.Format("{0} : {1}", Name, Price);
    }

}