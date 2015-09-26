List<Product> products = Product.GetSampleProducts();
products.Sort(delegate(Product x, Product y)
{
	return x.Name.CompareTo(y.Name);
});

foreach(Product p in products)
	Console.WriteLine(p);