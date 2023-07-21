namespace Computer_Store
{
	enum StoreState
	{
		MainMenu,
		DisplayItem,
		AddItem,
	}

	internal class Store
	{
		public void Stores()
		{
			List<Article> articles = new List<Article>();
			Article article1 = new Article(25, "Logitech G635", 234241424, "HeadPhones", 9000, 53);
			Article article2 = new Article(21, "Logitech G Pro", 15686734, "HeadPhones", 16000, 50);
			articles.Add(article1);
			articles.Add(article2);
			StoreState state = StoreState.MainMenu;
			bool exit = true;

			while (exit)
			{
				switch (state)
				{
					case StoreState.MainMenu:
						Console.Clear();
						MainMenu();
						int choice = MainMenuChoice();
						switch (choice)
						{
							case 1: state = StoreState.DisplayItem; break;
							case 2: state = StoreState.AddItem; break;
							case 0: exit = false; break;
						}
						break;

					case StoreState.DisplayItem:
						DisplayItems(articles);
						state = StoreState.MainMenu;
						break;

					case StoreState.AddItem:
						articles.Add(article1);
                        Console.WriteLine(article1);
						break;
                }
			}
		}
		private void AddItem(List<Article> articles)
		{
			
		}
		private void DisplayItems(List<Article> articles)
		{
			Console.WriteLine("Currently available items are: (Press any key to go back to Main Menu)");
			for (int i = 0; i < articles.Count; i++)
			{
				int discount = (articles[i].GetPrice() * articles[i].GetDiscount()) / 100;
				discount = articles[i].GetPrice() - discount;
				Console.WriteLine("ID: {0} Name: {1} Type: {2} Hashcode: {3} Price: {4} Discount: {5}% Price with discount: {6}"
					, articles[i].GetID(), articles[i].GetName(), articles[i].GetType(), articles[i].GetBarCode(), articles[i].GetPrice()
					, articles[i].GetDiscount(), discount);
			}
			Console.ReadKey(true);
		}
		private int MainMenuChoice()
		{
			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice))
			{
				Console.WriteLine("Invalid choice");
			}
			return choice;
		}
		private void MainMenu()
		{
			Console.WriteLine("Welcome to the store please select a option (Type 0 to exit)");
			Console.WriteLine("[1] Display items");
			Console.WriteLine("[2] Add item");
			Console.WriteLine("[3] Remove Item");
		}		
	}
}
