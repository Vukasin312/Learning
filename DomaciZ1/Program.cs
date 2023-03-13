namespace DomaciZ1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Interval interval1 = new Interval(6, 12, 25, true);
			Interval interval2 = new Interval(11, 12, 25, true);
			Console.WriteLine("Interval 1: {0} interval 2: {1}", interval1.Render(), interval2.Render());

			interval1.Equals(interval2);
			interval1.GreaterThan(interval2);
			interval1.LessThan(interval2);

			//interval1.Add(interval2);
			Console.WriteLine(interval1.Render()); 

			interval1.Subtract(interval2);
			Console.WriteLine(interval1.Render());

			

			Console.ReadKey();
		}
	}
}