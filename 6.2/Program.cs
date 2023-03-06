namespace Interface6._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var circle = new Circle(5);
			var circle2 = new Circle(10);
			var circleArea1 = circle.GetArea();
			var circlePerimetar1 = circle.GetPerimeter();

			Console.WriteLine("Area1 = {0} Area2 = {1}", circleArea1, circle2.GetArea());
			Console.WriteLine("Perimeter1 = {0} Perimeter2 = {1}", circlePerimetar1, circle2.GetPerimeter());

			Rectangle rectangle = new Rectangle(2, 5);
			Rectangle rectangle2 = new Rectangle(4, 15);


			Console.WriteLine("Rectangle1 area = {0}", rectangle.GetArea());
			Console.WriteLine("Rectangle2 area = {0}", rectangle2.GetArea());
			Console.WriteLine("Rectangle1 perimeter = {0}", rectangle.GetPerimeter());
			Console.WriteLine("Rectangle2 perimeter = {0}", rectangle2.GetPerimeter());

			Console.ReadKey();
		}
	}
}