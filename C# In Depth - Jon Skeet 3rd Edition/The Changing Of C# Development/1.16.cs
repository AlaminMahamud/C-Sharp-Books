List<Product> products = Product.GetSampleProducts();

List<Supplier> suppliers = Supplier.GetSampleSuppliers();

var filtered = from p in products 
			   join s in suppliers
			   		on p.SupplierID equals s.SupplierID
			   	where p.price>10
			   	orderby s.Name, p.Name
			   	select new {SupplierName = s.Name, ProductName = p.Name};
foreach(var v in filtered)
{
	Console.WriteLine("Supplier={0};
					   Product ={1}",v.SupplierName, v.ProductName);
}