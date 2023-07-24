namespace Generic
{
    class program
	{
		public static void Main(string[] args)
		{
			int[] myArray={1,2,4,5,6,8};
			double[] arr={1.1,2.5,3.5,5.6,5.6,5.5};
			char[] arrs={'a','b','o','u','t'};
			
			Console.WriteLine("The integer array contains:");
			DisplayArray(myArray);
			Console.WriteLine("The double array contains:");
			DisplayArray(arr);
			Console.WriteLine("The char array contains:");
			DisplayArray(arrs);

		}
	}
}

			
