using System.Collections.Generic;
using System.ComponentModel;

namespace View.Util
{
	public static class ListConverter
	{
		public static BindingList<T> convert<T,S>(List<S> input) where T:S
		{
			BindingList<T> output = new BindingList<T>();
			foreach(var el in input)
			{
				output.Add((T)el);
			}

			return output;
		}
	}
}
