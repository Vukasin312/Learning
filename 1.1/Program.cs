namespace _1._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Circle circle = new Circle(2, "red");
			Console.WriteLine("Circle area is {0}, and radio is {1}", circle.GetArea(), circle.GetRadius());
			Console.WriteLine("Circle color is {0}", circle.GetColor());

			Circle circle2 = new Circle();
			Console.WriteLine("Circle2 area is {0}, and radio is {1}", circle2.GetArea(), circle2.GetRadius());
			Console.WriteLine("Circle2 color is {0}", circle2.GetColor());

			Circle circle3 = new Circle(5, "black");
			circle3.SetRadius(3);
			circle3.SetColor("blue");
			Console.WriteLine("Circle3 area is {0}, and radio is {1}", circle3.GetArea(), circle3.GetRadius());
			Console.WriteLine("Circle3 color is {0}", circle3.GetColor());

			Circle circle4 = new Circle(5.5, "Orange");
			Console.WriteLine(circle4.ToString());

			Circle circle5 = new Circle(6.6, "White");
			Console.WriteLine(circle5.ToString());
			Console.WriteLine(circle5);
			Console.WriteLine("Operator '+' invokes toString() too: " + circle5);

			Console.ReadKey();
		}
	}
}