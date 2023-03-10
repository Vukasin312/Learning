namespace _1._7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Date date = new Date(29, 2, 2016);
			date.Print();

			date.SetMonth(2);
			date.SetDay(29);
			date.SetYear(2000);
			date.Print();
			Console.WriteLine("Month: {0}", date.GetMonth());
			Console.WriteLine("Day: {0}", date.GetDay());
			Console.WriteLine("Year: {0}", date.GetYear());

			date.SetDate(3, 4, 2016);
			date.Print();

			Console.ReadKey();
		}
	}
}