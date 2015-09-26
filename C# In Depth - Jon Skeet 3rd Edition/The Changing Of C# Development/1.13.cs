// testing With A Lambda Expression

List<Product> products = Product.GetSampleProducts();
foreach(Product p in products.Where(p=>p.price>10m))
{
	Console.WriteLine(p);
}