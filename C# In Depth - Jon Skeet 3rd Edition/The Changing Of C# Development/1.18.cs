// Applying a query expression to a SQL database (C# 3)

using (LinqDemoDataContext db = new LinqDemoDataContext())
{
	var filtered =  from p in db.Products
					join s in db.Suppliers
					on p.SupplierID equals s.SupplierID
					where p.Price > 10
					orderby s.Name, p.Name
					select new { SupplierName = s.Name, ProductName = p.Name };

	foreach (var v in filtered)
	{
	Console.WriteLine("Supplier={0}; Product={1}",v.SupplierName, v.ProductName);
	}
}

