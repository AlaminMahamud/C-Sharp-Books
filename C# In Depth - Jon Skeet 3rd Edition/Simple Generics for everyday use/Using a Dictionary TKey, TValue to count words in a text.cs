//

// Using A Dictoionary<TKey, TValue> to count words in text

// 

// static method

// return type Dictionary<string,int>

// input (string text)

// creating maps


static Dictionary<string,int> CountWords(string text)
{
	Dictionary<string,int> frequencies;
	frequencies = new Dictionary<string, int>();

	string[] words = Regex.Split(text, @"\W+");

	foreach(string word in words)
	{
		if(frequencies.ContainsKey(word))
		{
			frequencies[word]++;
		}	
		else
		{
			frequencies[word]=1;
		}
	}
	return frequencies;
}

... 

string text = @"Do yiu like ross?
				No I Like Joey.
			   ";

Dictionary<string,int> count = CountWords(text);
foreach(KeyValuePair<string,int> entry in frequencies)
{
	string word = entry.Key;
	int frequency = entry.Value;
	Console.WriteLine("{0} : {1}", word, frequency);
}


