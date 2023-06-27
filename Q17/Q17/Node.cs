using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q17
{
	public class Node
	{
		int data;
		Node next;

		public int Data
		{
			get { return data; }
			set { data = value; }
		}
		public Node Next
		{
			get { return next; }
			set { next = value; }
		}

		public Node(int Data)
		{
			data = Data;
			next = null;
		}
	}
}
