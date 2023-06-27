namespace Q18
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Stack stack = new Stack();
			Stack result = new Stack();
			int item;
			int item1;
			for (int i = 1; i <= 5; i++)
			{
				Console.WriteLine("Enter Item to Push ");
				item = int.Parse(Console.ReadLine());
				stack.Push(item);
				stack.Display();
			}
		}
	}
}