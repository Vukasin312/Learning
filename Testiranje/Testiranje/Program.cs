namespace Testiranje
{
	interface IItem
	{
		string Name { get; }
	}
	interface IMovable
	{
		void Move();
	}
	interface IBuyable
	{
		double Price { get; }
		void Buy();
	}

	class Car : IItem, IMovable, IBuyable
	{
		public double Price { get; private set; }
		public string Name { get; private set; }

		public Car(string name, double price)
		{
			Name = name;
			Price = price;
		}
		public void Move()
		{
			Console.WriteLine("WROOOMM");
		}
		public void Buy()
		{
			Console.WriteLine("You successfully bought a {0} for {1}$", Name, Price);
		}
	}
	class Chair : IItem, IMovable
	{
		public string Name { get; private set; }
		public Chair(string name)
		{
			Name = name;
		}
		public void Move()
		{
			Console.WriteLine("Moving the {0} chair", Name);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<IItem> items = new List<IItem>();
			AddItems(items);
			Inputs(items);

			Console.ReadKey();
		}

		private static void AddItems(List<IItem> items)
		{
			while (true)
			{
				Console.WriteLine("What do you want to add [1] Car [2] Chair? (Press 0 to exit)");
				int answer = 0;
				int input = Answer(answer);
				if (input != 1 && input != 2 && input != 0)
				{
					Console.WriteLine("Please select a valid number");
				}
				else if (input == 1)
				{
					Console.WriteLine("Enter a Car name and price in $");
					items.Add(new Car(Console.ReadLine(), int.Parse(Console.ReadLine())));
				}
				else if (input == 2)
				{
					Console.WriteLine("Enter a type of chair");
					items.Add(new Chair(Console.ReadLine()));
				}
				else if (input == 0)
					break;
			}
		}

		private static void Inputs(List<IItem> items)
		{
			while (true)
			{
				int answer = 0;
				IItem chosenItem = ChooseItem(items);
				var movable = chosenItem as IMovable;
				var buyable = chosenItem as IBuyable;
				Console.WriteLine("Whar do you want to do? [1 - move] [2 - buy]");
				int input = Answer(answer);
				if (movable != null && input == 1)
				{
					movable.Move();
				}
				if (buyable != null && input == 2)
				{
					buyable.Buy();
				}
			}
		}

		static IItem ChooseItem(List<IItem> items)
		{
			while (true)
			{
				int index = 1;
				foreach (IItem item in items)
				{
					Console.Write("[{0}] {1}", index++, item.Name);

					IBuyable buyable = item as IBuyable;
					if (buyable != null)
					{
						Console.Write(" - costs {0}", buyable.Price);
					}
					IMovable movable = item as IMovable;
					if (movable != null)
					{
						Console.Write(" chair - is movable");
					}
					Console.WriteLine();
				}
				Console.WriteLine("Choose item");
				int itemIndex;
				if (!int.TryParse(Console.ReadLine(), out itemIndex))
				{					
					Console.WriteLine("Please enter a number");
				}
				else if (itemIndex <= 0 || itemIndex > items.Count)
				{
					Console.WriteLine("Enter a valid number");
				}
				else return items[itemIndex - 1];
			}			
		}
		static int Answer(int answer)
		{
			while (true)
			{
				if (!int.TryParse(Console.ReadLine(), out answer))
				{
					Console.WriteLine("Please enter a number");
				}
				else return answer;
			}			
		}
	}

}