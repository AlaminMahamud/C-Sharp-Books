// Ordering a List<Product> using an Extension Methods

List<Product> products = Product.GetSampleProducts();
foreach(Product p in products.OrderBy(p=>p.Name))
	Console.WriteLine(p);