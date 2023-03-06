using System;

namespace ConsoleApp7
{
	enum ProgramState
	{
		MainMenu,
		AddItem,
		DisplayItems,
		RemoveItem,
		
	}

	class Program
	{
		static void Main(string[] args) 
		{
			List<string> items = new List<string>();
			ProgramState state = ProgramState.MainMenu;
			

			while (true)
			{
				switch (state)
				{
					case ProgramState.MainMenu:
						Console.WriteLine("Main menu");
						Console.WriteLine("[1] Add item");
						Console.WriteLine("[2] Display items");
						Console.WriteLine("[3] Remove item");

						int choice;

						if (!int.TryParse(Console.ReadLine(), out choice))
						{
							Console.WriteLine("Invalid input");
						}
						switch (choice)
						{
							case 1 : state = ProgramState.AddItem; break;
							case 2 : state = ProgramState.DisplayItems; break;
							case 3 : state = ProgramState.RemoveItem; break;
						}
						break;

					case ProgramState.DisplayItems:
						Console.WriteLine("Items");
						
						for (int index1 = 0; index1 < items.Count; index1++)
						{
							Console.WriteLine("[{0}] {1}", (index1 + 1), items[index1]);
						}
						
						Console.WriteLine("Press any key to exit to main menu");
						Console.ReadKey(true);
						state = ProgramState.MainMenu;
						break;

					case ProgramState.AddItem:
						Console.WriteLine("What item do you want to add?");
						items.Add(Console.ReadLine());
						state = ProgramState.MainMenu;
						break;

					case ProgramState.RemoveItem:
						Console.WriteLine("What item do you want to remove?");
						Console.WriteLine("Press enter to exit to main manu");
						int index = 0;
						while (true)
						{
							int answer = int.Parse(Console.ReadLine());

							for (index = 0; index < items.Count; index++)
							{
								Console.WriteLine("[{0}] {1}", (index + 1), items[index]);
							}
							if (answer == (index + 1))
							{
								items.RemoveAt(answer);
							}
							else if (answer == 0)
							{
								state = ProgramState.MainMenu;
								break;
							}							
							else if (answer != (index + 1))
							{
								Console.WriteLine("Invalid input");
							}
						}
						
						break;
				}
				Console.Clear();
			}
		}
	}
}