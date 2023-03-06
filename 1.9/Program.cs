namespace _1._9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Ball ball = new Ball(1.0f, 2.2f, 10, 3.3f, 4.4f);
			ball.Print();

			ball.SetX(80.0f);
			ball.SetY(35.0f);
			ball.SetRadius(5);
			ball.SetXDelta(4.0f);
			ball.SetYDelta(6.0f);

			ball.Print();
			Console.WriteLine("x is : {0}", ball.GetX());
			Console.WriteLine("y is : {0}", ball.GetY());
			Console.WriteLine("radius is : {0}", ball.GetRadius());
			Console.WriteLine("xDelta is : {0}", ball.GetXDelta());
			Console.WriteLine("xDelta is : {0}", ball.GetYDelta());

			float xMin = 0.0f;
			float xMax = 100.0f;
			float yMin = 0.0f;
			float yMax = 50.0f;

			Bounce(ball, xMin, xMax, yMin, yMax);

			Console.ReadLine();
		}

		private static void Bounce(Ball ball, float xMin, float xMax, float yMin, float yMax)
		{
			for (int i = 0; i < 15; i++)
			{
				ball.Move();
				ball.Print();
				float xNew = ball.GetX();
				float yNew = ball.GetY();
				int radius = ball.GetRadius();

				if ((xNew + radius) > xMax || (xNew - radius) < xMin)
				{
					ball.ReflectHorizontal();
				}
				else if ((yNew + radius) > yMax || (yNew - radius) < yMin)
				{
					ball.ReflectVertical();
				}
			}
		}
	}
}