List<Product> products = Product.GetSampleProducts();

var filtered = from Product p in products
			   where p.Price > 10
			   select p;

foreac(Product product in filtered)
{
	Console.WriteLine(product);
}