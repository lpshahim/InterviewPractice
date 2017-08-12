using System;

namespace BitManipulation
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] arr = { 1, 3, 5,7, 3, 5, 1, 6,6 };
			int ans = lonelyInt(arr);
			Console.WriteLine(ans);
		}

		static int lonelyInt(int[] arr) {
			int result = 0;

			foreach (int i in arr) {
				result ^= i;
			}

			return result;
		}
	}
}
