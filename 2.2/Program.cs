namespace _2._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string test = "test";
			test = test + "test2";
			Console.WriteLine(test);
			Author[] authors = new Author[2];
			authors[0] = new Author("Vukasin", "rexxar.simic66@gmail.com", 'm');
			authors[1] = new Author("Tijana", "tijana@gmail.com", 'f');					
			Book book = new Book("Knjiga", authors, 19.99, 99);

			book.GetAuthorName();
			Console.WriteLine(book.Render());


			Console.ReadKey();
		}
	}
}