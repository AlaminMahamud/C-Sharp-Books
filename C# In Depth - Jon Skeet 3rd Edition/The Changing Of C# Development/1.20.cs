// Running ironPython and extracting properties dynamically

ScriptEngine engine = Python.CreateEngine();
ScriptScope scope = engine.ExecuteFile("FindProducts.py");
dynamic products = scope.GetVariable("Products");
foreach(dynamic product in products)
{
	Console.WriteLine("{0} : {1}", product.ProductName, product.Price);
}