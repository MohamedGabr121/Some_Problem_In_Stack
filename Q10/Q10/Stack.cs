using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q10
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


		public int CountElementInStack(Stack stack, int element)
		{
			int count = 0;

			Stack temp = new Stack();

			while (!stack.IsEmpty())
			{
				int current = stack.Pop();
				if (current == element)
				{
					count++;
				}
				temp.Push(current);
			}

			while (!temp.IsEmpty())
			{
				stack.Push(temp.Pop());
			}

			return count;
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
