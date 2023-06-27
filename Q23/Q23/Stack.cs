using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q23
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

		public Stack CreateNewStackContainOnlyElementhatAreInEitherTheFirstOrTheSecondStackButNotInBoth(Stack stack)
		{
			Stack newStack = new Stack();
			HashSet<int> Elements = new HashSet<int>();
			Node current = top;
			while (current != null)
			{
				if (!Elements.Contains(current.Data))
				{
					newStack.Push(current.Data);
					Elements.Add(current.Data);
				}
				current = current.Next;
			}

			if (stack != null)
			{
				current = stack.top;
				while (current != null)
				{
					if (!Elements.Contains(current.Data))
					{
						newStack.Push(current.Data);
						Elements.Add(current.Data);
					}
					else
					{
						Elements.Remove(current.Data);
					}
					current = current.Next;
				}
			}

			return newStack;
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
