namespace _2._0
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Author vukasin = new Author("Vukasin", "rexxar.simic66@gmail.com", 'm');
			Console.WriteLine(vukasin.Render());

			Book book = new Book("Knjiga", vukasin, 19.95, 99);
			Console.WriteLine(book.Render());

			book.SetPrice(29.95);
			book.SetQty(28);
			Console.WriteLine("name is: {0}", book.GetName());
			Console.WriteLine("price is: {0}", book.GetPrice());
			Console.WriteLine("qty is: {0}", book.GetQty());
			Console.WriteLine("Author is: {0}", book.GetAuthor().Render());
			Console.WriteLine("Author's name is: {0}", book.GetAuthor().GetName());
			Console.WriteLine("Author's name is: {0}", book.GetAuthorName());
			Console.WriteLine("Author's email is: {0}", book.GetAuthor().GetEmail());


			Book anotherBook = new Book("Bolja knjiga", new Author("Tijana", "tijana@gmail.com", 'f'), 29.95);
			Console.WriteLine(anotherBook.Render());

			Console.ReadKey();
		}
	}
}