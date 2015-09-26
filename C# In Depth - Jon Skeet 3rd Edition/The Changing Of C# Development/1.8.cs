List<Product> products = Product.GetSampleProducts();
products.Sort((x,y) => x.Name.CompareTo(y.Name));
foreach(Product p in products)
	Console.WriteLine(p);