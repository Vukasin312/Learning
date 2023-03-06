namespace _1._8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Time time = new Time(11, 2, 1);
				time.SetSecond(22);
				Console.WriteLine("Second: {0}", time.GetSecond());
				time.Print();
				Console.WriteLine("--------------------");
				time.SetTime(11, 10, 59);
				time.Print();
				Console.WriteLine("--------------------");
				time.NextSecond();
				time.Print();
				Console.WriteLine("--------------------");
				time.NextSecond().NextSecond();
				time.Print();
				Console.WriteLine("--------------------");
				time.SetTime(23, 59, 59);
				time.Print();
				Console.WriteLine("--------------------");
				time.NextSecond();
				time.Print();
				Console.WriteLine("--------------------");

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}


			Console.ReadKey();
		}
	}
}