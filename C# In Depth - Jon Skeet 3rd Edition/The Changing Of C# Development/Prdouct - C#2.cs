// Strongly typed Collections

using System.Collections;

public class Product
{
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

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public static List<Product> GetSampleProducts()
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("West Side Story", 9.99m));
        list.Add(new Product("Assassins", 14.99m));
        list.Add(new Product("Frogs", 13.99m));
        list.Add(new Product("Sweeny Todd", 10.99m));

        return list;
    }

    public override string ToString()
    {
        return String.Format("{0} : {1}", Name, Price);
    }

}