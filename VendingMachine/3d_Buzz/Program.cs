using System;

namespace Program
{
	enum ProgramState
	{
		MainMenu,
		AddItem,
		DisplayItem,
		RemoveItem
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<string> items = new List<string>();
			List<double> prices = new List<double>();
			ProgramState state = ProgramState.MainMenu;
			bool exit = true;

			while (exit)
			{
				switch (state)
				{
					case ProgramState.MainMenu:
						MainMenu();
						int answer = Answer();
						switch (answer)
						{
							case 1: state = ProgramState.AddItem; break;
							case 2: state = ProgramState.DisplayItem; break;
							case 3: state = ProgramState.RemoveItem; break;
							case 0: exit = false; break;
						}
						break;

					case ProgramState.AddItem:
						AddItem(items, prices);
						state = ProgramState.MainMenu;
						break;

					case ProgramState.DisplayItem:
						ShowItems(items, prices);
						state = ProgramState.MainMenu;
						break;

					case ProgramState.RemoveItem:
						RemoveItems(items, prices);
						state = ProgramState.MainMenu;
						break;

				}
				Console.Clear();
			}
		}

		private static void MainMenu()
		{
			Console.WriteLine("Welcome to Main Menu please select a option (Type 0 to exit)");
			Console.WriteLine("[1] Add item");
			Console.WriteLine("[2] Display items");
			Console.WriteLine("[3] Remove Item");
		}

		private static void AddItem(List<string> items, List<double> prices)
		{
			Console.WriteLine("Enter name of the Item you want to add: ");
			items.Add(Console.ReadLine());
			Console.WriteLine("Enter a price for given item");
			prices.Add(double.Parse(Console.ReadLine()));
			Console.WriteLine("You successfully added a item. Press any key to go back to Main Menu");
			Console.ReadKey(true);
		}

		private static void ShowItems(List<string> items, List<double> prices)
		{
			Console.WriteLine("Your items are: (Press any key to go back to Main Menu)");
			for (int i = 0; i < items.Count; i++)
			{
				Console.WriteLine("[{0}] {1}, {2}$", (i + 1), items[i], prices[i]);
			}
			Console.ReadKey(true);
		}

		private static void RemoveItems(List<string> items, List<double> prices)
		{
			while (true)
			{
				Console.WriteLine("What item do you want to remove? (Enter 0 if you want to exit)");
				for (int i = 0; i < items.Count; i++)
				{
					Console.WriteLine("[{0}] {1}, {2}$", (i + 1), items[i], prices[i]);
				}
				int remover = Answer();
				if (remover > items.Count || remover < 0)
					Console.WriteLine("Please select item from the list");
				else if (remover == 0)
					break;
				else
				{
					items.RemoveAt((remover - 1));
					prices.RemoveAt((remover - 1));
				}
			}
		}

		static int Answer()
		{
			int answer = 0;
			if (!int.TryParse(Console.ReadLine(), out answer))
				Console.WriteLine("Please enter a number");
			return answer;
		}		
	}
}