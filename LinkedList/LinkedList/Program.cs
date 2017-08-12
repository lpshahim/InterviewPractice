using System;

namespace LinkedList
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Node threeNode = new Node(null, 3);
			Node twoNode = new Node(threeNode, 2);
			Node oneNode = new Node(twoNode, 1);

			LinkedList tList = new LinkedList();

			var myReversedList = tList.reverseList(oneNode);
			tList.printList(myReversedList);
		}
		public class Node
		{
			public Node next;
			public int data;

			public Node(Node n) {
				this.next = n;
			}
			public Node(Node n, int d)
			{
				this.next = n;
				this.data = d;
			}
		}

		public class LinkedList { 
			
			public void printList(Node head)
			{
				Node currentNode = head;

				while (currentNode != null)
				{
					Console.WriteLine(currentNode.data);
					currentNode = currentNode.next;
				}
			}

			public Node reverseList(Node head)
			{

				Node currentNode = head;
				Node prev = null;
				Node next;

				while (currentNode != null)
				{
					next = currentNode.next;
					currentNode.next = prev;
					prev = currentNode;
					currentNode = next;
				}
				return prev;
			}
		}
	}
}
