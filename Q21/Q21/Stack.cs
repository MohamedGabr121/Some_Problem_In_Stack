using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q21
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
		public void FindElementFristStackPutNotSecondStack(Stack stack1, Stack stack2)
		{
			// 1 2 3  || 1 2 4
			Stack findElementFristStack = new Stack();
			Node current1 = stack1.top;
			Node current2 = stack2.top;
			while (current1 != null && current2 != null)
			{

				if (current1.Data != current2.Data)
				{
					findElementFristStack.Push(current1.Data);
				}
				current1 = current1.Next;
				current2 = current2.Next;
			}
			while (!findElementFristStack.IsEmpty())
			{
				stack1.Push(findElementFristStack.Pop());
			}

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
