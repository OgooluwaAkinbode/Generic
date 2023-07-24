using System.Data;
using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic
{
	public class GenericMethod
	{
		private static void DisplayArray <T> (T[] inputArray)
		{
			foreach (T item in inputArray)
			{
				Console.Write(item + " ");
				
				Console.WriteLine("/n");
			}
		}
	}
}