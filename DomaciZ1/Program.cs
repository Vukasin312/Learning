namespace DomaciZ1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Interval interval1 = new Interval(10, 20, 30, true);
			Interval interval2 = new Interval(28, 23, 30, true);

			Interval result = interval1.Add(interval2);
			Console.WriteLine(result.Print());			

			result = interval1.Subtract(interval2);
			Console.WriteLine(result.Print());			

			Console.WriteLine("Interval 1: {0} interval 2: {1}", interval1.Print(), interval2.Print());
			
			interval1.Equals(interval2);			
			interval1.GreaterThan(interval2);
			interval1.LessThan(interval2);

			//TestClass.test();

			//TimeStamp timeStamp = new TimeStamp(2016, 10, 26, 10, 12, interval1);
			//TimeStamp timeStamp1 = new TimeStamp(2016, 10, 26, interval1);
			//Console.WriteLine(timeStamp.Print());
			//Console.WriteLine(timeStamp1.Print());
			//timeStamp.Add(interval1);
			//Console.WriteLine(timeStamp.Print());

			Console.ReadKey();
		}
	}
}