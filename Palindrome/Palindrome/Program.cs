using System;
using System.Text;

namespace Palindrome
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter string:");
			string check = Console.ReadLine();

			int len = check.Length;
			string reverse = "";


			for (int i = len-1 ; i >= 0; i--) {
				reverse += check[i];
			}

			if (check.Equals(reverse))
			{
				Console.WriteLine("Word is a palindrome.");
			}
			else {
				Console.WriteLine("Word is not a palindrome");
			}
		}
	}
}
