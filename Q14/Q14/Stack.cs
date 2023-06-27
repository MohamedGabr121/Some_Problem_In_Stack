﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q14
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

		public int Count()
		{
			Node current = top;
			int count = 0;
			while (current != null)
			{
				current = current.Next;
				count++;
			}
			return count;
		}


		public void RotateLeftStack(Stack stack)
		{
			var temp = new List<int>();
			while (stack.Count() > 0)
				temp.Add(stack.Pop());
			foreach (int i in temp)
				stack.Push(i);

		}

		public void SwapTheTopTwoElementOfStack(Stack stack)
		{
			// 3 2 1
			int topone = stack.Pop(); // 3
			int toptwo = stack.Pop(); // 2

			stack.Push(topone);
			stack.Push(toptwo);
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
