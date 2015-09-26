//Named Arguments for clear initialization code

using System.Collections.Generic;

public class Product
{
    //private string name;

    //public string Name
    //{
    //    get { return name; }
    //    private set { name = value; }
    //}

    //private decimal price;

    //public decimal Price
    //{
    //    get { return price; }
    //    private set { price = value; }
    //}
 

    //public string Name { get; private set; }
    //public decimal Price { get; private set; }


    //public Product(string name, decimal price)
    //{
    //    this.Name = name;
    //    this.Price = price;
    //}

    private readonly string name;
    public string Name {
        get { return name; }
    }

    private readonly decimal price;

    public decimal Price
    {
        get { return price; }
    }

    private Product()
    {
    
    }

    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product{name = "West Side Story", price = 9.99m},
            new Product{name = "Assasins", price = 14.99m},
            new Product{name = "Frogs", price = 13.99m},
            new Product{name = "Sweeny Todd", price = 10.99m}
        };
    }

    public override string ToString()
    {
        return String.Format("{0} : {1}", Name, Price);
    }

}