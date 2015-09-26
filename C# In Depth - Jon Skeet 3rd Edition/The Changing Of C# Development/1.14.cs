List<Product> products = Product.GetSampleProducts();

foreach(Product product in products.Where(p=>p.price == null))
{
	Console.WriteLine(product);
}

List<Product> products = Product.GetSampleProducts();
products.FindAll(delegate(Product p){return p.Price == null;})
		.ForEach(Console.WriteLine);

public Product(string name, decimal? price=null)
{
	this.name = name;
	this.price = price;
}
