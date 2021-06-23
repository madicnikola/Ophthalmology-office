using System.Collections.Generic;

namespace View.Util
{
	public class ListConverter
	{
		public static List<T> convert<T,S>(List<S> input) where T:S
		{
			List<T> output = new List<T>();
			foreach(var el in input)
			{
				output.Add((T)el);
			}

			return output;
		}
	}
}
