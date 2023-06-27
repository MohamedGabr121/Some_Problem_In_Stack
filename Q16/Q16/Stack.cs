using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q16
{
	public class Stack
	{
		Node top;
		public bool IsEmpty()
		{
			if (top == null)
				return true;
			else
				return false;
		}
		public void Push(int data)
		{
			Node newNode = new Node(data);
			newNode.Data = data;
			if (IsEmpty())
			{
				newNode.Next = null;
				top = newNode;
			}

			else
			{
				newNode.Next = top;
				top = newNode;
			}

		}

		public int Pop()
		{

			int value;
			if (IsEmpty())
			{
				Console.WriteLine("Stack underflow");
				return -1;
			}
			value = top.Data;
			top = top.Next;
			return value;
		}

		public int Peek()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Stack underflow");
				return -1;
			}
			return top.Data;
		}



		public int GetTheNthElementOfStack(Stack stack, int n)
		{
			Node current = top;
			for (int i = 1; i < n; i++)
			{
				if (current == null)
				{
					throw new ArgumentOutOfRangeException("n exceeds the number of elements in the stack");
				}
				current = current.Next;
			}
			return current.Data;
		}

		public void Display()
		{
			Node temp = top;

			while (temp != null)
			{
				Console.Write(temp.Data + " ");
				temp = temp.Next;
			}
			Console.WriteLine();
		}
	}
}
