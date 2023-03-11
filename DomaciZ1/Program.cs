namespace DomaciZ1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Interval interval1 = new Interval(6, 12, 25, true);
			Interval interval2 = new Interval(6, 12, 55, true);

			// nije dobro ne treba ti ovaj
			// kad napravis da ima 1 argument ce ti radi bez ovaj
			Interval newInterval = new Interval(0, 0, 0, true);

			newInterval.Add(interval1/*, interval2*/);
			newInterval.Render();

			newInterval.Subtract(interval1/*, interval2*/);
			newInterval.Render();

			newInterval.Equals(interval1, interval2);
			newInterval.GreaterThan(interval1, interval2);
			newInterval.LessThan(interval1, interval2);

			Console.ReadKey();
		}
	}
}