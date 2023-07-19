namespace GuessTheNumber
{
	internal class NumberNotGuess
	{
		private RandomNumber _randomNumber;		
		private GuessNumber _guessNumber;

		public string GoodGuess()
		{			
			string number = _guessNumber.GetGuessNumber();
			string random = _randomNumber.GetRandomNumber();
			bool notClose = true;
			bool close = false;
			bool hangInThere = false;
			if (number.Contains(random))
			{				
				for (int i = 0; i < 3; i++)
				{
					if (number.Contains(random[i]))
					{
						notClose = false;
						if (number[i] == random[i])
						{
							hangInThere = true;
						}
						else
						{
							notClose = true;
						}
					}
				}
			}
			else return "You are not close";			
			if (close) return "You are close";
			else return "Hang in there";

		}
	}
}
