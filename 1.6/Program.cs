namespace _1._6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Account account = new Account("A101", "Tijana Stankovic", 88);
			account.ToString();
			Account account2 = new Account("A102", "Vukasin Simic");
			account2.ToString();

			Console.WriteLine("ID: {0}", account.GetId());
			Console.WriteLine("Name: {0}", account.GetName());
			Console.WriteLine("Balance: {0}", account.GetBalance());

			account.Credit(100);
			account.ToString();
			account.Debit(50);
			account.ToString();
			account.Debit(500);
			account.ToString();

			account.TransferTo(account2, 100);
			account.ToString();
			account2.ToString();

			Console.ReadKey();
		}
	}
}