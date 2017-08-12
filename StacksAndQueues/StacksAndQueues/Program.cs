using System;

namespace StacksAndQueues
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		public class Stack {
			public class Node {
				public int data;
				public Node next;

				public Node(int d) {
					this.data = d;
				}
			}

			public Node top;

			public Boolean isEmpty() {
				return top == null;
			}
			public int peek() {
				return top.data;
			}
			public int pop() {
				int data = top.data;
				top.next = top;
				return data;
			}
			public void push(int data) {
				Node newNode = new Node(data);
				newNode.next = top;
				top = newNode;
			}
		}

		public class Queue {
			public class Node {
				public int data;
				public Node next;

				public Node(int d) {
					this.data = d;
				}
			}

			public Node head;
			public Node tail;

			public Boolean isEmpty() {
				return head == null;
			}
			public int peek() {
				if (head != null)
				{
					return head.data;
				}
			}
			public void add(int data) {
				Node newNode = new Node(data);
				if (tail != null) {
					tail.next = newNode;
				}
				if (head == null) { head = newNode;}
			}
			public int remove() {
				int data = head.data;
				head = head.next;

				if (head == null) { tail = null;}

				return data;
			}
		}
	}
}
