using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
	internal class GuessNumber
	{
		private string _guessNumber;		
		
		public string GetGuessNumber() { return _guessNumber; }
		public void SetGuessNumber()
		{
			_guessNumber = GetGuessNumber();
		}
		
		public string Guess()
		{			
			string number = Num();
			_guessNumber = number;			
			return _guessNumber;
		}
		public string Num()
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
			return guess.ToString();
		}
	}
}
