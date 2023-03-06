namespace _1._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Circle circle1 = new Circle(1.1);
			Console.WriteLine(circle1.ToString() + circle1.GetRadius());
			Console.WriteLine("Circle area is : {0}, and circumference is: {1}", circle1.GetArea(), circle1.GetCircumference());
			circle1.SetRadius(2.2);
			Console.WriteLine(circle1.ToString() + circle1.GetRadius());
			Console.WriteLine("Circle area is : {0}, and circumference is: {1}", circle1.GetArea(), circle1.GetCircumference());

			Circle circle2 = new Circle();
			Console.WriteLine(circle1.ToString() + circle2.GetRadius());			
			Console.WriteLine("Circle area is : {0}, and circumference is: {1}", circle2.GetArea(), circle2.GetCircumference());

			Console.ReadKey();
		}
	}
}