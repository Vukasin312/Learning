namespace _2._6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyPoint p1 = new MyPoint(2, 3);
			Console.WriteLine(p1.Print());
			p1.SetX(8);
			p1.SetY(6);
			Console.WriteLine("x is : " + p1.GetX());
			Console.WriteLine("x is : " + p1.GetY());
			p1.SetXY(3, 0);
			Console.WriteLine(p1.GetXY()[0]);
			Console.WriteLine(p1.GetXY()[1]);
			Console.WriteLine(p1.Print());

			MyPoint p2 = new MyPoint(0, 4);
			Console.WriteLine(p2.Print());
			Console.WriteLine(p1.Distance(p2));
			Console.WriteLine(p2.Distance(p1));
			Console.WriteLine(p1.Distance(5, 6));
			Console.WriteLine(p1.Distance());

			MyPoint[] points = new MyPoint[10];

			for (int i = 0; i < points.Length; i++)
			{
				points[i] = new MyPoint(i+1, i+1);
			}
			for (int i = 0; i < points.Length; i++)
			{
				Console.WriteLine(points[i].Print());
			}

			Console.ReadKey();
		}
	}
}