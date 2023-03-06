using _1._9._1;

namespace _1._9._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Ball ball = new Ball(1.0f, 2.2f, 10, 3, 30);
			ball.Print();

			ball.SetX(80.0f);
			ball.SetY(35.0f);
			ball.SetRadius(5);
			ball.GetSpeed(4);
			ball.SetDirectionInDegree(45);

			ball.Print();
			Console.WriteLine("x is : {0}", ball.GetX());
			Console.WriteLine("y is : {0}", ball.GetY());
			Console.WriteLine("radius is : {0}", ball.GetRadius());
			Console.WriteLine("xDelta is : {0}", ball.GetSpeed());
			Console.WriteLine("xDelta is : {0}", ball.GetDirectionInDegree());

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