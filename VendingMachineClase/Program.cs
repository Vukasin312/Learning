namespace VendingMachineClase
{
	enum ProgramState
	{
		MainMenu,
		AddItem,
		RemoveItem,
		DisplayItem
	}
	class Answer
	{
		public int Case()
		{
			int answer;
			if (!int.TryParse(Console.ReadLine(), out answer))
				Console.WriteLine("Please enter a number");
			return answer;
		}
	}
	class Product
	{
		public string Item;
		public double Price;
		public Product(string items, double prices)
		{
			Item = items;
			Price = prices;
		}

		public void Display()
		{
			Console.WriteLine("{0}, {1}$", Item, Price);
		}
		public void RemoveItem()
		{

		}
	}

	class MainMenu
	{
		public void Display()
		{
			Console.WriteLine("Welcome to Main Menu please select a option (Type 0 to exit)");
			Console.WriteLine("[1] Add item");
			Console.WriteLine("[2] Display items");
			Console.WriteLine("[3] Remove Item");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			ProgramState state = ProgramState.MainMenu;
			string item;
			double prices;
			MainMenu mainMenu = new MainMenu();
			Answer answer = new Answer();
			List<Product> products = new List<Product>();
			bool exit = false;
			while (!exit)
			{
				switch (state)
				{
					case ProgramState.MainMenu:
						Console.Clear();
						mainMenu.Display();
						switch (answer.Case())
						{
							case 1: state = ProgramState.AddItem; break;
							case 2: state = ProgramState.DisplayItem; break;
							case 3: state = ProgramState.RemoveItem; break;
							case 0: exit = false; break;
						}
						break;

					case ProgramState.AddItem:
						Console.WriteLine("Enter a product name (or enter to stop): ");
						item = Console.ReadLine();

						Console.WriteLine("Enter product Price: $");
						if (!double.TryParse(Console.ReadLine(), out prices))
							Console.WriteLine("Please enter a correct number");

						products.Add(new Product(item, prices));
						state = ProgramState.MainMenu;
						break;

					case ProgramState.DisplayItem:
						Console.Clear();
						foreach (Product product in products)
						{
							product.Display();
						}
						Console.ReadKey(true);
						state = ProgramState.MainMenu;
						break;

					case ProgramState.RemoveItem:
						Console.WriteLine("What item do you want to remove (Enter 0 if you want to exit)");
						foreach (Product additem in products)
						{
							additem.Display();
						}
						int remover = int.Parse(Console.ReadLine());
						if (remover > products.Count || remover < 0)
							Console.WriteLine("Plese select product from the list!");
						else if (remover == 0)
							break;
						else
						{
							products.RemoveAt(remover - 1);
							Console.WriteLine("Product successfully removed");
						}
						Console.ReadKey(true);
						state = ProgramState.MainMenu;
						break;
				}
			}
			Console.ReadKey();
		}
	}
}