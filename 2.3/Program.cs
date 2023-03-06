namespace _2._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Author a1 = new Author("Than Aha Teck", "ahteck@nowhere.com");
			Console.WriteLine(a1.Render());

			a1.SetEmail("ahteck@somewhere.com");
			Console.WriteLine(a1.Render());
			Console.WriteLine("name is : {0}", a1.GetName());
			Console.WriteLine("email is : {0}", a1.GetEmail());

			Book b1 = new Book("12345", "Java for dummies", a1, 8.8, 88);
			Console.WriteLine(b1.Render());

			b1.SetPrice(9.9);
			b1.SetQty(99);
			Console.WriteLine(b1.Render());
			Console.WriteLine("isbn is: " + b1.GetIsbn());
			Console.WriteLine("name is: " + b1.GetName());
			Console.WriteLine("price is: " + b1.GetPrice());
			Console.WriteLine("qty is: " + b1.GetQty());
			Console.WriteLine("author is: " + b1.GetAuthor().Render());
			Console.WriteLine("author name is: " + b1.GetAuthorName());
			Console.WriteLine("author name is: " + b1.GetAuthor().GetName());
			Console.WriteLine("email is: " + b1.GetAuthor().GetEmail());

			Console.ReadKey();
		}
	}
}