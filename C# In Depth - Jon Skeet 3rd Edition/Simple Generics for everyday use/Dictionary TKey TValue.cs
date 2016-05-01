using System.Collections.Generic;

namespace BlaBla
{

	public class Dictionary<TKey,TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
	{
		// Parameter Less Constructor

		public Dictionary()
		{
			// ...
		}

		// 

		public TValue this[TKey key]
		{
			get
			{
				//...
			}

			set
			{
				// ...
			}
		}

		public void Add(TKey key, TValue value)
		{
			// ... 
		}

		public void Remove(TKey key)
		{
			// ....
		}

		public bool ContainsKey(TKey key)
		{
			//...
		}

		public bool ContainsValue(TValue value)
		{
			//...
		}

		/*
			[Other Members]
		*/
	}

}