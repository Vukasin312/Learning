namespace DomaciZ1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Interval interval1 = new Interval(6, 12, 25, true);
			Interval interval2 = new Interval(6, 12, 55, true);
			Interval newInterval = new Interval(0, 0, 0, true);

			newInterval.Add(interval1, interval2);
			newInterval.Render();

			newInterval.Substract(interval1, interval2);
			newInterval.Render();

			newInterval.Equals(interval1, interval2);
			newInterval.GreaterThan(interval1, interval2);
			newInterval.LessThan(interval1, interval2);

			Console.ReadKey();
		}
	}
}