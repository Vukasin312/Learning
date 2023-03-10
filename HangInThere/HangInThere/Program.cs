namespace HangInThere
{
	class Program
	{
		static void Main(string[] args)
		{
			string random = Random();
			//Console.WriteLine(random);
			Console.WriteLine("Enter a three digit number: ");
			int tries = 0;
			List<string> listNotClose = new List<string>();
			List<string> listClose = new List<string>();
			List<string> listHangInThere = new List<string>();

			bool exit = false;

			while (!exit)
			{
				tries++;
				string guessString = Guess();
				if (guessString.Contains(random))
				{
					Console.WriteLine("Congratulations!!!");
					if (tries == 1)
						Console.WriteLine("You got in on your first try!!!");
					else
						Console.WriteLine("You needed {0} tries to win", tries);
					exit = true;
				}
				if (guessString.Length != 3)
					Console.WriteLine("Your guess is to Low or to How");

				if (!guessString.Contains(random) && guessString.Length == 3)
				{
					string stringNotClose = "";
					string stringClose = "";
					string stringHangInThere = "";
					bool notClose = true;
					bool hangInThere = false;

					for (int i = 0; i < 3; i++)
					{
						if (random.Contains(guessString[i]))
						{
							notClose = false;
							if (random[i] == guessString[i] && !hangInThere)
							{
								stringHangInThere = guessString;
								stringClose = "";
								hangInThere = true;
							}
							else if (random[i] != guessString[i] && !hangInThere)
							{
								stringClose = guessString;
							}
						}
					}
					if (!hangInThere && notClose)
					{
						stringNotClose = guessString;
					}
					listNotClose.Add(stringNotClose);
					listClose.Add(stringClose);
					listHangInThere.Add(stringHangInThere);
					Print(listNotClose, listClose, listHangInThere);
				}
			}
			Console.ReadKey(true);
		}

		private static void Print(List<string> listNotClose, List<string> listClose, List<string> listHangInThere)
		{
			Console.Clear();
			Console.WriteLine("| Not Close      | Close          | Hang in There  |");
			Console.WriteLine("|----------------+----------------+----------------|");

			for (int index = 0; index < listNotClose.Count ||
				index < listHangInThere.Count ||
				index < listClose.Count; index++)
			Console.WriteLine("| {0, -14} | {1, -14} | {2, -14} |",
				listNotClose[index], listClose[index], listHangInThere[index]);
		}

		static string Random()
		{
			Random random = new Random();
			int randomNumber = random.Next(100, 999);
			string numberToString = randomNumber.ToString();
			return numberToString;
		}

		static string Guess()
		{
			int guess;
			while (!int.TryParse(Console.ReadLine(), out guess))
			{
				Console.WriteLine("Please enter a number: ");
			}
			string guessString = guess.ToString();
			return guessString;
		}
	}
}