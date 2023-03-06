namespace _1._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var rectangle = new Rectangle(1.2f, 3.4f);
			Console.WriteLine(rectangle.ToString());
			Console.WriteLine("Rectangle Area is: {0} and perimeter {1}", rectangle.GetArea(), rectangle.GetPerimeter());
			rectangle.SetLength(5.6f);
			rectangle.SetWidth(7.8f);
			Console.WriteLine(rectangle.ToString());
			Console.WriteLine("Rectangle Area is: {0} and perimeter {1}", rectangle.GetArea(), rectangle.GetPerimeter());

			var rectangle2 = new Rectangle();
			Console.WriteLine(rectangle2.ToString());
			Console.WriteLine("Rectangle Area is: {0} and perimeter {1}", rectangle2.GetArea(), rectangle2.GetPerimeter());

			Console.ReadKey();
		}
	}
}