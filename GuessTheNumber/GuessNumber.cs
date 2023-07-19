namespace GuessTheNumber
{
	internal class GuessNumber
	{
		private string _guessNumber;
		public GuessNumber()
		{
			_guessNumber = GetGuessNumber();
		}
		public string GetGuessNumber() { return _guessNumber; }
		public string YourGuess()
		{
			int guess;
			while (!int.TryParse(Console.ReadLine(), out guess))
			{
				Console.WriteLine("That is not a number");
			}
			if (guess < 100 || guess > 999)
			{
				Console.WriteLine("Please Enter a number between 100 and 999!");
			}
			return _guessNumber = guess.ToString();
		}
	}
}
