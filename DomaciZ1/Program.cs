namespace DomaciZ1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Interval interval1 = new Interval(17, 2, 15, false);
			//Interval interval2 = new Interval(25, 5, 45, true);
			Interval zero = new Interval(0, 0, 0, true);

			////61, 20, 17, false

			//Interval result = interval1.Add(interval2);
			//Console.WriteLine(result.Print());			

			//result = interval1.Subtract(interval2);
			//Console.WriteLine(result.Print());			

			//Console.WriteLine("Interval 1: {0} interval 2: {1}", interval1.Print(), interval2.Print());

			//interval1.Equals(interval2);			
			//interval1.GreaterThan(interval2);
			//interval1.LessThan(interval2);

			//TestClass.test();
			//Interval interval = new Interval(6666666, 3, 23, true);
			//Interval zoneOffSet = new Interval(0, 5, 30, true);

			TimeStamp timeStamp = new TimeStamp(2000, 12, 15, 10, 30, zero);
			TimeStamp timeStamp2 = new TimeStamp(1997, 1, 31, 15, 15, zero);
			//TimeStamp timeStamp1 = new TimeStamp(2016, 10, 26, zoneOffSet);

			//Console.WriteLine(timeStamp.Print());
			//Console.WriteLine(interval.Print());
			//Console.WriteLine(timeStamp1.Print());

			//TimeStamp result = timeStamp.Add(interval);
			//Console.WriteLine(result.Print());

			//TimeStamp result1 = timeStamp.Subtract(interval);
			//Console.WriteLine(result1.Print());
			TimeStamp result2 = timeStamp.SubtractTimeStamps(timeStamp2);
			Console.WriteLine(result2.Print());

			Console.ReadKey();
		}
	}
}