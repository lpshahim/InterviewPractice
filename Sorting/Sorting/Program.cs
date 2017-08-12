using System;

namespace Sorting
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] array = { 7, 9, 3, 5, 1, 4, 2, 6, 8, 0 };
			foreach (int i in array) {
				Console.WriteLine(i);
			}

			Console.WriteLine("\nSORTED:\n");

			Quicksort(array, 0, 9);

			foreach (int i in array) {
				Console.WriteLine(i);
			}

		}

		static int Partition(int[] A, int start, int end) {
			int pivot = A[end];
			int partitionIndex = start;

			for (int i = start; i < end; i++) {
				if (A[i] <= pivot) {
					int temp = A[i];
					A[i] = A[partitionIndex];
					A[partitionIndex] = temp;

					partitionIndex++;     
				}
			}
			int temp1 = A[partitionIndex];
			A[partitionIndex] = A[end];
			A[end] = temp1;
			//Swap(A[partitionIndex], A[end]);

			return partitionIndex;
		}

		static void Quicksort(int[] A, int start, int end) {
			if (start < end) {
				int partitionIndex = Partition(A, start, end);
				Quicksort(A, start, partitionIndex - 1);
				Quicksort(A, partitionIndex + 1, end);
			}
		}

		static void Swap(int a, int b) {
			int temp = a;
			a = b;
			b = temp;
		}
	}
}
