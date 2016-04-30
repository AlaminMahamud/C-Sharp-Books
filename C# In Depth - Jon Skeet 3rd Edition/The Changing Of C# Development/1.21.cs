static string Reverse(string input)
{
	char[] chars = input.ToCharArray();
	Array.Reverse(chars);
	return new string(chars);
}

...

Console.WriteLine(Reverse("dlrow olleH"));
