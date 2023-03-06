namespace _2._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Customer c1 = new Customer(88, "Vukasin", 10);
			Console.WriteLine(c1.Render());

			c1.SetDiscount(8);
			Console.WriteLine(c1.Render());
			Console.WriteLine("id is: " + c1.GetId());
			Console.WriteLine("name is: " + c1.GetName());
			Console.WriteLine("discount is: " + c1.GetDiscount());

			Invoice inv1 = new Invoice(101, c1, 999.9);
			Console.WriteLine(inv1.Render());
			Console.WriteLine("amount after discount is: " + inv1.GetAmountAfterDiscount());

			Console.ReadKey();
		}
	}
}